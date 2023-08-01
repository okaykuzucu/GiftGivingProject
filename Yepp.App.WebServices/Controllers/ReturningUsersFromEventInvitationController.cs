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
    public class ReturningUsersFromEventInvitationController : ControllerBase
    {
        private readonly IReturningUsersFromEventInvitationService _returningUsersFromEventInvitationService;
        private readonly IDataSecurity _dataSecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturningUsersFromEventInvitationController"/> class.
        /// </summary>
        /// <param name="returningUsersFromEventInvitationService">The returning users from event invitation service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public ReturningUsersFromEventInvitationController(
           IReturningUsersFromEventInvitationService returningUsersFromEventInvitationService,
           IDataSecurity dataSecurity
           )
        {
            _returningUsersFromEventInvitationService = returningUsersFromEventInvitationService;
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
            var _result = await _returningUsersFromEventInvitationService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the returning users from event invitation.
        /// </summary>
        /// <param name="returningUsersFromEventInvitationAddOptions">The returning users from event invitation add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddReturningUsersFromEventInvitation(ReturningUsersFromEventInvitationAddOptions returningUsersFromEventInvitationAddOptions)
        {

            var _result = await _returningUsersFromEventInvitationService.AddAsync(returningUsersFromEventInvitationAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Updates the returning users from event invitation.
        /// </summary>
        /// <param name="returningUsersFromEventInvitationUpdateDto">The returning users from event invitation update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateReturningUsersFromEventInvitation(ReturningUsersFromEventInvitationUpdateDto returningUsersFromEventInvitationUpdateDto)
        {
            var _result = await _returningUsersFromEventInvitationService.UpdateByIdAsync(
                new Guid(returningUsersFromEventInvitationUpdateDto.Id),
                returningUsersFromEventInvitationUpdateDto.ReturningUsersFromEventInvitationUpdateOptions
                );
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

        }
    }
}
