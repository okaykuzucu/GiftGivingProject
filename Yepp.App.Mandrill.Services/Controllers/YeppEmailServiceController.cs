using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Yepp.App.Mandrill.Services.Models.Requests;
using Yepp.App.Mandrill.Services.Services;
using ActionNameAttribute = System.Web.Http.ActionNameAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Yepp.App.Mandrill.Services.Controllers
{
    /// <summary>
    /// YeppApp Email RestApi Services
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [ApiController]
    [RoutePrefix("api/YeppEmailService")]
    public class YeppEmailServiceController : ApiController
    {

        /// <summary>
        /// Emails the activation.
        /// </summary>
        /// <param name="gameInfoEmailInformationRequest">The game information email information request.</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("GameEmailInformation")]
        public async Task<IHttpActionResult> GameInfoEmailInformation(GameInfoEmailInformationRequest gameInfoEmailInformationRequest)
        {
            MandrillService.GameInfoEmailInformation(
                            gameInfoEmailInformationRequest.Order, 
                            gameInfoEmailInformationRequest.Name, 
                            gameInfoEmailInformationRequest.Email, 
                            gameInfoEmailInformationRequest.Language
                            );

            return 
                Content(HttpStatusCode.OK, HttpStatusCode.OK.ToString());
        }
        /// <summary>
        /// Paymeses the information email information.
        /// </summary>
        /// <param name="paymesInfoEmailInformationRequest">The paymes information email information request.</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("PaymesInfoEmailInformation")]
        public async Task<IHttpActionResult> PaymesInfoEmailInformation(PaymesInfoEmailInformationRequest paymesInfoEmailInformationRequest)
        {
            MandrillService.PaymesInfoEmailInformation(
                            paymesInfoEmailInformationRequest.Email,
                            paymesInfoEmailInformationRequest.Language,
                            paymesInfoEmailInformationRequest.Name,
                            paymesInfoEmailInformationRequest.Order
                            );
            return
                Content(HttpStatusCode.OK, HttpStatusCode.OK.ToString());
        }

        /// <summary>
        /// Emails the activation.
        /// </summary>
        /// <param name="gameInfoEmailInformationRequest">The game information email information request.</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("UserVerification")]
        public async Task<IHttpActionResult> UserVerification(UserVerificationRequest userVerificationRequest)
        {
             MandrillService.UserVerification(
                userVerificationRequest.UserId,
                userVerificationRequest.UserName,
                userVerificationRequest.UserLastName,
                userVerificationRequest.Language,
                userVerificationRequest.UserEmail);

            return
                Content(HttpStatusCode.OK, HttpStatusCode.OK.ToString());
        }


        /// <summary>
        /// Emails the activation.
        /// </summary>
        /// <param name="gameInfoEmailInformationRequest">The game information email information request.</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("UserCongratulation")]
        public async Task<IHttpActionResult> UserCongratulation(UserCongratulationRequest userCongratulationRequest)
        {
            MandrillService.UserCongratulation(
            userCongratulationRequest.UserEmail,
            userCongratulationRequest.Language,
            userCongratulationRequest.UserName+" "+userCongratulationRequest.UserLastName);

            return
                Content(HttpStatusCode.OK, HttpStatusCode.OK.ToString());
        }

        [HttpPost]
        [ActionName("UserForgotPassword")]
        public async Task<IHttpActionResult> UserForgotPassword(UserForgotPasswordRequest userForgotPasswordRequests)
        {
            MandrillService.UserForgotPassword(
                userForgotPasswordRequests.UserName, userForgotPasswordRequests.UserLastName,
                userForgotPasswordRequests.Language,
                userForgotPasswordRequests.UserEmail,
                userForgotPasswordRequests.Password);

            return
                Content(HttpStatusCode.OK, HttpStatusCode.OK.ToString());
        }


    }
}