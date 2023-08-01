using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Yepp.App.Bussines.Securities;
using Yepp.App.Services;
using Yepp.App.Services.Models;
using Yepp.App.WebServices.Dtos;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IDataSecurity _dataSecurity;


        /// <summary>
        /// Initializes a new instance of the <see cref="EventController" /> class.
        /// </summary>
        /// <param name="eventService">The event service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public EventController(
            IEventService eventService,
            IDataSecurity dataSecurity
            )
        {
            _eventService = eventService;
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
            var _result = await _eventService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the event.
        /// </summary>
        /// <param name="eventAddOptions">The event add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddEvent(EventAddOptions eventAddOptions)
        {
            var alleventlist = await _eventService.ListAsync();
            var event_count_by_user_id = alleventlist.Where(x => x.UserId == eventAddOptions.UserId).Count();

            //if (event_count_by_user_id < 5)
            //{
            var _result = await _eventService.AddAsync(eventAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

            //}
            //else
            //{
            //    return
            //        new ObjectResult("max event count asildi") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            //}


        }

        /// <summary>
        /// Updates the event.
        /// </summary>
        /// <param name="eventUpdateDto">The event update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateEvent(EventUpdateDto eventUpdateDto)
        {
            var _event = await _eventService.GetDetail(new Guid(eventUpdateDto.Id));

            if (_event.UserId != eventUpdateDto.EventUpdateOptions.UserId)
            {
                return new ObjectResult("Event User'a ait değil..") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }


            var _result = await _eventService.UpdateByIdAsync(
                new Guid(eventUpdateDto.Id),
               eventUpdateDto.EventUpdateOptions
                );
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }


        /// <summary>
        /// Updates the event.
        /// </summary>
        /// <param name="eventUpdateDto">The event update dto.</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateEventForPayment(EventUpdateDto eventUpdateDto)
        {
            var _result = await _eventService.UpdateByIdAsync(
                new Guid(eventUpdateDto.Id),
               eventUpdateDto.EventUpdateOptions
                );
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail user.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Event> GetDetailEventAsAnonymous(string id)
        {
            var _event = await _eventService.GetDetail(new Guid(id));

            if(_event.payuPaymentReference != null)
            {
                var dict = new Dictionary<string, string>();
                dict.Add("paymentReference", _event.payuPaymentReference);

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "") { Content = new FormUrlEncodedContent(dict) };
                var response = await client.SendAsync(request);

                var paymesApiStringResult = await response.Content.ReadAsStringAsync();
                dynamic paymesApijsonResult = JsonConvert.DeserializeObject(paymesApiStringResult);
                string status = paymesApijsonResult.status;


                var eventUpdateOptions = new EventUpdateOptions();
                eventUpdateOptions.UserId = _event.UserId;
                eventUpdateOptions.CategoryId = _event.CategoryId;
                eventUpdateOptions.Title = _event.Title;
                eventUpdateOptions.Description = _event.Description;
                eventUpdateOptions.Image = _event.Image;
                eventUpdateOptions.TotalBalance = _event.TotalBalance;
                eventUpdateOptions.EndDate = _event.EndDate;
                eventUpdateOptions.StatusId = _event.StatusId;
                eventUpdateOptions.payuPaymentReference = _event.payuPaymentReference;
                if (status == "success")
                {
                    eventUpdateOptions.payment = true;
                }
                else if (status == "failed")
                {
                    eventUpdateOptions.payment = false;
                }

                var _result = await _eventService.UpdateByIdAsync(_event.Id,
                   eventUpdateOptions
                    );

                return _result;
            }
            else
            {
                return _event;
            }
            
        }

        /// <summary>
        /// Gets the detail user.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<Event> GetDetailEvent(string id)
        {

            return await _eventService.GetDetail(new Guid(id));
        }

        /// <summary>
        /// Gets the event by user identifier.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetEventListByUserId(string userId)
        {

            var EventListByUserId =await _eventService.GetEventByUserId(new Guid(userId));
                      
                return
                    new ObjectResult(EventListByUserId) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };           

        }
        /// <summary>
        /// Deletes the event.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        [Authorize]
        public async Task DeleteEventById(string id)
        {
            var eventId = new Guid(id);
            await _eventService.DeleteByIdAsync(eventId);
        }

        /// <summary>
        /// Deletes the event list by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        [HttpDelete]
        [Authorize]
        public async Task DeleteEventListByUserId(string userId)
        {
            var Id = new Guid(userId);

            await _eventService.DeleteEventListByUserId(Id);
        }


        /// <summary>
        /// Creates the image.
        /// </summary>
        /// <param name="eventImageDto">The event image dto.</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("CreateImage")]
        public async Task<IActionResult> CreateImage(EventImageDto eventImageDto)
        {
            if (eventImageDto.Img == null)
            {
                return new ObjectResult("Img is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            if (eventImageDto.EventId == null)
            {
                return new ObjectResult("EventId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            if (eventImageDto.Img.Length == 0)
            {
                return new ObjectResult("Img is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            else
            {
                string uzanti = ".jpg";

                Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
                string str = regex.Replace(eventImageDto.Img, string.Empty);
                Byte[] bytes = Convert.FromBase64String(str);


                var request = (FtpWebRequest)WebRequest.Create("ftp://92.205.7.115//" + eventImageDto.EventId + uzanti);

                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.Credentials = new NetworkCredential("", "");


                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }

                var response = (FtpWebResponse)request.GetResponse();

                eventImageDto.ImgPath = "https://yepp.app/yepp_event_images/" + eventImageDto.EventId + uzanti;

                return new ObjectResult(eventImageDto) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
            }


        }

    }
}


