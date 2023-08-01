using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Yepp.App.Bussines.Securities;
using Yepp.App.Services.Models;
using Yepp.App.Services;
using Yepp.App.WebServices.Dtos;
using System.Text.RegularExpressions;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GiftController : ControllerBase
    {
        private readonly IGiftService _giftService;
        private readonly IDataSecurity _dataSecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="GiftController"/> class.
        /// </summary>
        /// <param name="giftService">The gift service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public GiftController(
            IGiftService giftService,
            IDataSecurity dataSecurity
            )
        {
            _giftService = giftService;
            _dataSecurity = dataSecurity;
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetList()
        {
            var _result = await _giftService.ListAsync();

            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the gift.
        /// </summary>
        /// <param name="giftAddOptions">The gift add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddGift(GiftAddOptions giftAddOptions)
        {
            var _result = await _giftService.AddAsync(giftAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Updates the gift.
        /// </summary>
        /// <param name="giftUpdateDto">The gift update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateGift(GiftUpdateDto giftUpdateDto)
        {
            var _result = await _giftService.UpdateByIdAsync(
                new Guid(giftUpdateDto.Id),
                giftUpdateDto.GiftUpdateOptions
                );
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail gift.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetDetailByGift(string giftId)
        {
            if (giftId == null)
            {
                return new ObjectResult("giftId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            /*
             * TO-DO
             *  https://yepp-pyapi.azurewebsites.net/get_gift_image_and_price
             *  tan img ve price ı çektikten sonra UpdateGift fonksiyonu ile güncelledikten sonra _giftService.GetDetail ile verileri dönen akış yapılacak
             *  */

            var _result = await _giftService.GetDetail(new Guid(giftId));
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Deletes the gift.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        [Authorize]
        public async Task DeleteGiftById(string id)
        {
            var giftId = new Guid(id);
            await _giftService.DeleteByIdAsync(giftId);
        }

        /// <summary>
        /// Deletes the gift by event identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        [Authorize]
        public async Task DeleteGiftByEventId(string eventid)
        {
            var eventId = new Guid(eventid);
            await _giftService.DeleteByIdAsync(eventId);

            //var tempgift = new GiftEntity { Id = new Guid(eventid) };
            //DataContext.Attach(tempgift);
            //DataContext.Remove(tempgift);
        }

        /// <summary>
        /// Gets the list by event identifier.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetGiftListByEventId(string eventId)
        {
            if (eventId == null)
            {
                return new ObjectResult("eventId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var GiftListByEventId = await _giftService.GetListByEventId(new Guid(eventId));

            return
                new ObjectResult(GiftListByEventId) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the gift list by event identifier as anonymous.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetGiftListByEventIdAsAnonymous(string eventId)
        {
            if (eventId == null)
            {
                return new ObjectResult("eventId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var GiftListByEventId = await _giftService.GetListByEventId(new Guid(eventId));

            return
                new ObjectResult(GiftListByEventId) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail gift as anonymous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Gift> GetDetailGiftAsAnonymous(string id)
        {

            return await _giftService.GetDetail(new Guid(id));
        }

        /// <summary>
        /// Deletes the gift list by event identifier.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Authorize]
        public async Task DeleteGiftListByEventId(string eventId)
        {
            var Id = new Guid(eventId);
            await _giftService.DeleteGiftListByEventId(Id);
        }

        /// <summary>
        /// Creates the image.
        /// </summary>
        /// <param name="giftImageDto">The gift image dto.</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("CreateImage")]
        public async Task<IActionResult> CreateImage(GiftImageDto giftImageDto)
        {
            if (giftImageDto.Img == null)
            {
                return new ObjectResult("Img is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            if (giftImageDto.GiftId == null)
            {
                return new ObjectResult("GiftId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            if (giftImageDto.Img.Length == 0)
            {
                return new ObjectResult("Img is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            else
            {
                string uzanti = ".jpg";

                Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
                string str = regex.Replace(giftImageDto.Img, string.Empty);
                Byte[] bytes = Convert.FromBase64String(str);


                var request = (FtpWebRequest)WebRequest.Create("ftp://92.205.7.115//" + giftImageDto.GiftId + uzanti);

                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.Credentials = new NetworkCredential("", "");


                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }

                var response = (FtpWebResponse)request.GetResponse();

                giftImageDto.ImgPath = "https://yepp.app/yepp_gift_images/" + giftImageDto.GiftId + uzanti;

                return new ObjectResult(giftImageDto) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
            }


        }
    }
}