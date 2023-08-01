using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Yepp.App.Bussines.Securities;
using Yepp.App.Services;
using Yepp.App.Services.Models;
using Yepp.App.WebServices.Dtos;
using Yepp.App.WebServices.Models.Requests;
using Yepp.App.WebServices.Validations;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IDataSecurity _dataSecurity;
        private readonly CheckMailValidation _checkMailValidation;
        private readonly CheckUserAddValidation _checkUserAddValidation;
        private readonly IHttpClientFactory _mandrillClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="userService">The user service.</param>
        public UserController(
            IUserService userService,
            IDataSecurity dataSecurity,
            IHttpClientFactory mandrillClient
            )
        {
            _userService = userService; ;
            _dataSecurity = dataSecurity;
            _mandrillClient = mandrillClient;
            _checkMailValidation = new CheckMailValidation();
            _checkUserAddValidation = new CheckUserAddValidation();
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetList()
        {
            var _result = await _userService.ListAsync();

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="userAddOptions">The user add options.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddUser(UserAddOptions userAddOptions)
        {
            var emailValidator = await _checkUserAddValidation.ValidateAsync(userAddOptions);
            if (!emailValidator.IsValid)
            {
                return new ObjectResult(emailValidator) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            userAddOptions.Password = await Task.Run(() => _dataSecurity.Encriyption(userAddOptions.Password));
            var user = await _userService.IsRegistered(userAddOptions.Email);

            //TODO  : Eğer içeride gelen email adresi varsa kullanıcı maili kullanılıyor hatası dönülür.
            //Yusuf a söylenmeli 201 dönerse bu mail adresi kullanılıyor hatasıdır.
            if (user)
            {
                return
                   new ObjectResult("Kayıt daha önceden oluşturulmuş.") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            //TODO : Eksik veri veya veri formatı hatası
            var _result = await _userService.AddAsync(userAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            _result.CreatedDate.ToShortDateString();
            _result.RegistrationDate.Value.ToShortDateString();

            var data = new UserVerificationRequest();
            data.UserId = _result.Id.ToString();
            data.UserName = _result.Name;
            data.Language = _result.Language;
            data.UserLastName = _result.SurName;
            data.UserEmail = _result.Email;

            var request = new HttpRequestMessage(HttpMethod.Post, "api/YeppEmailService/UserVerification");
            string json = JsonSerializer.Serialize(data);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = _mandrillClient.CreateClient("yepp-mandrill-api");
            var response = await httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                return
                     new ObjectResult("Aktivasyon e-mail i gönderilemedi..") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound };
            }

            //TODO : Kayıt Başarılı ise UI tarafta aktivasyon mailiniz email hesabınıza gönderildi..
            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail user.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetDetailUser(string guid)
        {
            var _result = await _userService.GetDetail(new Guid(guid));
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail user.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetDetailUserByEmail(string email)
        {
            var _result = await _userService.GetDetailByEmail(email);
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="userUpdateDto">The user update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateUser(UserUpdateDto userUpdateDto)
        {
            var user = await _userService.GetDetail(new Guid(userUpdateDto.Id));

            if (user.Email != userUpdateDto.UserUpdateOptions.Email)
            {
                return new ObjectResult("E-mail ile id uyuşmuyor..") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            var _result = await _userService.UpdateByIdAsync(
                new Guid(userUpdateDto.Id),
                userUpdateDto.UserUpdateOptions
                );
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="forgotPasswordDto">The forgot password dto.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDto forgotPasswordDto)
        {
            var emailValidator = await _checkMailValidation.ValidateAsync(forgotPasswordDto);
            if (!emailValidator.IsValid)
            {
                return new ObjectResult(emailValidator) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var user = await _userService.IsRegistered(forgotPasswordDto.Email);

            //İçeride mail adresi kayıtlı değil ise
            if (!user)
            {
                return
                   new ObjectResult("Mail adresi kayıtlı değil.") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound };
            }

            var userDetail = await _userService.GetDetailMail(forgotPasswordDto.Email);

            var newPass = Guid.NewGuid().ToString("d").Substring(1, 8);

            var updateUser = new UserUpdateOptions();
            updateUser.Name = userDetail.Name;
            updateUser.Language = userDetail.Language;
            updateUser.SurName = userDetail.SurName;
            updateUser.Email = userDetail.Email;
            updateUser.Image = userDetail.Image;
            updateUser.IsRegistered = userDetail.IsRegistered;
            updateUser.KvkkChecked = userDetail.KvkkChecked;
            updateUser.RegistrationDate = userDetail.RegistrationDate;
            updateUser.Role_id = userDetail.RoleId;
            updateUser.Telephone = userDetail.Telephone;
            updateUser.UpdatedDate = DateTime.UtcNow;
            updateUser.Password = await Task.Run(() => _dataSecurity.Encriyption(newPass));

            var userUpdate = await _userService.UpdateByIdAsync(userDetail.Id, updateUser);

            updateUser.Password = newPass;

            var mandrillPost = new Yepp.App.WebServices.Models.Requests.UserForgotPasswordRequest();
            mandrillPost.Language = updateUser.Language;
            mandrillPost.Password = newPass;
            mandrillPost.UserEmail = updateUser.Email;
            mandrillPost.UserId = userDetail.Id.ToString();
            mandrillPost.UserName = updateUser.Name;
            mandrillPost.UserLastName = updateUser.SurName;

            var request = new HttpRequestMessage(HttpMethod.Post, "api/YeppEmailService/UserForgotPassword");
            string json = JsonSerializer.Serialize(mandrillPost);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = _mandrillClient.CreateClient("yepp-mandrill-api");
            var response = await httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                return
                     new ObjectResult("Şifreniz e-mail hesabınıza gönderilemedi..") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound };
            }

            //Mandrill ve MailChimp implementasyonu uygulanacak.
            return new ObjectResult("Şifreniz e-mail hesabınıza gönderildi.") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="changePasswordDto">The change password dto.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto changePasswordDto)
        {
            if (changePasswordDto.NewPassword != changePasswordDto.CheckNewPassword)
            {
                return new ObjectResult("Şifreniz Uyuşmuyor!") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status406NotAcceptable };
            }
            var encryptPassword = await Task.Run(() => _dataSecurity.Encriyption(changePasswordDto.CurrentPassword));
            var check = await _userService.UserCheckPassword(new Guid(changePasswordDto.UserId), encryptPassword);
            if (!check)
            {
                return new ObjectResult("Mevcut Şifreniz Yanlış!") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound };
            }

            var _userUpdateOptions = new UserUpdateOptions();
            _userUpdateOptions.Password = await Task.Run(() => _dataSecurity.Encriyption(changePasswordDto.NewPassword));

            var user = await _userService.ChangeUserPassword(new Guid(changePasswordDto.UserId), _userUpdateOptions);

            return new ObjectResult(user) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the user information.
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> GetUserInfo()
        {
            var user = new UserInfo();
            user.Id = 1;
            user.Email = "";
            user.UserName = "";
            user.Password = "";
            user.RefreshToken = "";
            user.AccessToken = "";
            var address = new UserAddresses();
            address.AddressLine = "Ataşehir - Kayışdağı - Ayaz Sokak";
            address.City = "";
            address.State = "";
            address.PostCode = "";
            user.Address = address;
            user.Roles = Enumerable.Range(1, 1).ToArray();
            var communitaciton = new Communication();
            communitaciton.Email = true;
            communitaciton.Sms = false;
            communitaciton.Phone = false;
            user.Communication = communitaciton;
            user.CompanyName = "";

            var emailSettings = new EmailSettings();
            var activityRelatesEmail = new ActivityRelatesEmail();
            activityRelatesEmail.MemberRegistration = true;
            activityRelatesEmail.NewMembershipApproval = false;
            activityRelatesEmail.SomeoneAddsYouAsAsAConnection = true;
            activityRelatesEmail.UponNewOrder = false;
            activityRelatesEmail.YouAreSentADirectMessage = false;
            activityRelatesEmail.YouHaveNewNotifications = true;
            emailSettings.ActivityRelatesEmail = activityRelatesEmail;
            emailSettings.EmailNotification = true;
            emailSettings.SendCopmyToPersonalEmail = false;
            var updatesFromKeenthemes = new UpdatesFromKeenthemes();
            updatesFromKeenthemes.NewsAboutKeenthemesProductsAndFeatureUpdates = false;
            updatesFromKeenthemes.NewsAboutMetronicOnPartnerProductsAndOtherServices = true;
            updatesFromKeenthemes.ThingsYouMissedSindeYouLastLoggedIntoKeen = true;
            updatesFromKeenthemes.TipsOnGettingMoreOutOfKeen = false;
            updatesFromKeenthemes.TipsOnMetronicBusinessProducts = true;

            emailSettings.UpdatesFromKeenthemes = updatesFromKeenthemes;
            user.EmailSettings = emailSettings;
            user.FirstName = "";
            user.FullName = "";
            user.Language = "en";
            user.LastName = "";
            user.Occupation = "";
            user.Phone = "";
            user.Picture = "toAbsoluteUrl(" + "/" + "+media" + "+/" + "users" + "/" + "300_21.jpg" + ")";
            var socialNetwork = new SocialNetworks();
            socialNetwork.Facebook = "https://linkedin.com/admin";
            socialNetwork.LinkedIn = "https://linkedin.com/admin";
            socialNetwork.Twitter = "https://linkedin.com/admin";
            socialNetwork.Instagram = "https://linkedin.com/admin";
            user.SocialNetworks = socialNetwork;
            user.TimeZone = "International Date Line West";
            user.WebSite = "https://linkedin.com/admin";

            var json = JsonSerializer.Serialize(user);
            return new ObjectResult(json) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Users the congratulation.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("UserCongratulation")]
        public async Task<IActionResult> UserCongratulation(string userId)
        {
            var user = await _userService.UserRegistered(userId);
            var data = new UserCongratulationRequest();

            data.Language = user.Language;
            data.UserEmail = user.Email;
            data.UserLastName = user.SurName;
            data.UserName = user.Name;

            var request = new HttpRequestMessage(HttpMethod.Post, "api/YeppEmailService/UserCongratulation");
            string json = JsonSerializer.Serialize(data);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = _mandrillClient.CreateClient("");
            var response = await httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            return Redirect("https://yepp.app/auth/login");
        }

        /// <summary>
        /// Creates the image.
        /// </summary>
        /// <param name="userImageDto">The user image dto.</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("CreateImage")]
        public async Task<IActionResult> CreateImage(UserImageDto userImageDto)
        {
            if (userImageDto.Img == null)
            {
                return new ObjectResult("Img is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            if (userImageDto.UserId == null)
            {
                return new ObjectResult("UserId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            if (userImageDto.Img.Length == 0)
            {
                return new ObjectResult("Img is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            else
            {
                string uzanti = ".jpg";

                Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
                string str = regex.Replace(userImageDto.Img, string.Empty);
                Byte[] bytes = Convert.FromBase64String(str);

                var request = (FtpWebRequest)WebRequest.Create("" + userImageDto.UserId + uzanti);

                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.Credentials = new NetworkCredential("", "");

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }

                var response = (FtpWebResponse)request.GetResponse();

                userImageDto.ImgPath = "" + userImageDto.UserId + uzanti;

                return new ObjectResult(userImageDto) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
            }
        }
    }
}