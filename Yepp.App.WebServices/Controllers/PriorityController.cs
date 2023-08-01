using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Yepp.App.Bussines.Securities;
using Yepp.App.Services;
using Yepp.App.Services.Models;
using Yepp.App.WebServices.Validations;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PriorityController : ControllerBase
    {
        private readonly IPriorityService _priorityService;
        private readonly IDataSecurity _dataSecurity;
        private readonly CheckMailValidation _checkMailValidation;
        private readonly CheckUserAddValidation _checkUserAddValidation;
        private readonly IHttpClientFactory _mandrillClient;


        /// <summary>
        /// New instance of the <see cref="PriorityController" /> class.
        /// </summary>
        /// <param name="priorityService">The priority service.</param>
        public PriorityController(
            IPriorityService priorityService,
             IDataSecurity dataSecurity,
             IHttpClientFactory mandrillClient
            )
        {
            _priorityService = priorityService;
            _dataSecurity = dataSecurity;
            _mandrillClient = mandrillClient;
            _checkMailValidation = new CheckMailValidation();
            _checkUserAddValidation = new CheckUserAddValidation();

        }
        /// <summary>
        /// Getlists this instance.
        /// </summary>
        /// <returns>
        ///   <br /></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetList()
        {
            var _result = await _priorityService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the role.
        /// </summary>
        /// <param name="priorityAddOptions">The priority add options.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPriority(PriorityAddOptions priorityAddOptions)
        {
            var _result = await _priorityService.AddAsync(priorityAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }
            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Deletes the role.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Authorize]
        public async Task DeletePriority(string id)
        {
            var priorityId = new Guid(id);
            await _priorityService.DeleteByIdAsync(priorityId);
        }
    }
}
