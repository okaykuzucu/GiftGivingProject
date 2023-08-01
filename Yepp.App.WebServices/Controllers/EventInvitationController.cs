using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Yepp.App.Bussines.Securities;
using Yepp.App.Services;
using Yepp.App.Services.Models;
using Yepp.App.WebServices.Dtos;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EventInvitationController : ControllerBase
    {
        private readonly EventInvitationService _eventInvitationService;
        private readonly IDataSecurity _dataSecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventInvitationController"/> class.
        /// </summary>
        /// <param name="eventInvitationService">The event invitation service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public EventInvitationController(
            IEventInvitationService eventInvitationService,
            IDataSecurity dataSecurity)
        {
            _eventInvitationService = (EventInvitationService)eventInvitationService;
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
            var _result = await _eventInvitationService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

        }

        /// <summary>
        /// Gets the event invitation list by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetEventInvitationListByUserId(string userId)
        {
            if (userId == null)
            {
                return new ObjectResult("userId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var EventInvitationListByUserId = await _eventInvitationService.GetEventInvitationByUserId(new Guid(userId));

                 return
                      new ObjectResult(EventInvitationListByUserId) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

        }
        /// <summary>
        /// Adds the event invitation.
        /// </summary>
        /// <param name="eventInvitationAddOptions">The event invitation add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddEventInvitation(EventInvitationAddOptions eventInvitationAddOptions)
        {
            var _result = await _eventInvitationService.AddAsync(eventInvitationAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }
            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }
        /// <summary>
        /// Updates the event invitation.
        /// </summary>
        /// <param name="eventInvitationUpdateDto">The event invitation update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]

        public async Task<IActionResult> UpdateEventInvitation(EventInvitationUpdateDto eventInvitationUpdateDto)
        {
            var _result = await _eventInvitationService.UpdateByIdAsync(
                new Guid(eventInvitationUpdateDto.Id),
                eventInvitationUpdateDto.EventInvitationUpdateOptions
                );
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }
        /// <summary>
        /// Gets the detail event invitation.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<EventInvitation> GetDetailEventInvitation(string guid)
        {
            return await _eventInvitationService.GetDetail(new Guid(guid));
        }

        /// <summary>
        /// Gets the detail by tracking number.
        /// </summary>
        /// <param name="trackingNumber">The tracking number.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetDetailByTrackingNumber(string trackingNumber)
        {
            if (trackingNumber == null)
            {
                return new ObjectResult("trackingNumber is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var _result = await _eventInvitationService.GetDetailByTrackingNumber(trackingNumber);
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Deletes the event by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        [Authorize]
        public async Task DeleteEventInvitationById(string id)
        {
            var id_ = new Guid(id);
            await _eventInvitationService.DeleteByIdAsync(id_);
        }
    }
}
