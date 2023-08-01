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
    public class EventStatusController : ControllerBase
    {
        private readonly EventStatusService _eventStatusService;


        /// <summary>
        /// Initializes a new instance of the <see cref="EventStatusController"/> class.
        /// </summary>
        /// <param name="eventStatusService">The event status service.</param>
        public EventStatusController(IEventStatusService eventStatusService)
        {
            _eventStatusService = (EventStatusService)eventStatusService;
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetList()
        {
            var _result = await _eventStatusService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail event status.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<EventStatus> GetDetailEventStatus(string id)
        {
            return await _eventStatusService.GetDetail(new Guid(id));
        }

        /// <summary>
        /// Gets the list as anonymous.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetListAsAnonymous()
        {
            var _result = await _eventStatusService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail event status.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<EventStatus> GetDetailEventStatusAsAnonymous(string id)
        {
            return await _eventStatusService.GetDetail(new Guid(id));
        }
    }
}
