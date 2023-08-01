using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Yepp.App.Bussines.Securities;
using Yepp.App.Services;
using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class InvitationChannelController : ControllerBase
    {
        /// <summary>
        /// The invitation channel
        /// </summary>
        private readonly InvitationChannelService _invitationChannelService;
        private readonly IDataSecurity _dataSecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationChannelController"/> class.
        /// </summary>
        /// <param name="invitationChannelService">The invitation channel service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public InvitationChannelController(
            IInvitationChannelService invitationChannelService,
            IDataSecurity dataSecurity
            )
        {
            _invitationChannelService = (InvitationChannelService)invitationChannelService;
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
            var _result = await _invitationChannelService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

        }

        /// <summary>
        /// Adds the invitaton channel.
        /// </summary>
        /// <param name="invitationChannelAddOptions">The invitation channel add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddInvitatonChannel(InvitationChannelAddOptions invitationChannelAddOptions)
        {
            var _result = await _invitationChannelService.AddAsync(invitationChannelAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Updates the invitation channel.
        /// </summary>
        /// <param name="invitationChannelUpdateDto">The invitation channel update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateInvitationChannel(InvitationChannelUpdateDto invitationChannelUpdateDto)
        {
            var _result = await _invitationChannelService.UpdateByIdAsync(
                new Guid(invitationChannelUpdateDto.Id),
                invitationChannelUpdateDto.InvitationChannelUpdateOptions
                );
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

        }

        /// <summary>
        /// Gets the detail invitation channel.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<InvitationChannel> GetDetailInvitationChannel(string guid)
        {
            return await _invitationChannelService.GetDetail(new Guid(guid));
        }
    }
}
