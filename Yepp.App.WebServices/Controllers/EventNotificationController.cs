using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Yepp.App.Services;
using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EventNotificationController : ControllerBase
    {

        private readonly IEventNotificationService _eventNotificationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventNotificationController"/> class.
        /// </summary>
        /// <param name="eventNotificationService">The event notification service.</param>
        public EventNotificationController(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetList()
        {
          var _resultList = await _eventNotificationService.ListAsync();


              return new ObjectResult(_resultList) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail event notification.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<EventNotification> GetDetailEventNotification(string guid)
        {
            return await _eventNotificationService.GetDetail(new Guid(guid));
        }

        /// <summary>
        /// Deletes the event by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        [Authorize]
        public async Task DeleteEventById(string id)
        {
            var eventId = new Guid(id);
            await _eventNotificationService.DeleteByIdAsync(eventId);
        }

        /// <summary>
        /// Adds the event notification.
        /// </summary>
        /// <param name="eventNotificationAddOptions">The event notification add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddEventNotification(EventNotificationAddOptions eventNotificationAddOptions)
        {
            var _result = await _eventNotificationService.AddAsync(eventNotificationAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }
            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }


    }
}
