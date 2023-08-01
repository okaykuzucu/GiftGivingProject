using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Yepp.App.Services.Models;
using Yepp.App.Services;
using Yepp.App.WebServices.Dtos;

namespace Yepp.App.WebServices.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmailListController : ControllerBase
    {
        /// <summary>
        /// The email list service
        /// </summary>
        private readonly IEmailListService _emailListService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailListController"/> class.
        /// </summary>
        /// <param name="EmailListService">The email list service.</param>
        public EmailListController(
            IEmailListService EmailListService)
        {
            _emailListService = EmailListService;
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var _result = await _emailListService.ListAsync();

            if(_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return
               new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the email list.
        /// </summary>
        /// <param name="emailListAddOptions">The email list add options.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddEmailList(EmailListAddOptions emailListAddOptions)
        {
            var _result = await _emailListService.AddAsync(emailListAddOptions);
            if (_result == null)
            {
                return
                     new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }
            return
               new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail by email list.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetDetailByEmailList(string id)
        {
            if (id == null)
            {
                return new ObjectResult("id is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            var _result = await _emailListService.GetDetail(new Guid(id));

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Updates the email list.
        /// </summary>
        /// <param name="emailListUpdateDto">The email list update dto.</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateEmailList(EmailListUpdateDto emailListUpdateDto)
        {
            var _result = await _emailListService.UpdateByIdAsync(
                new Guid(emailListUpdateDto.Id),
                emailListUpdateDto.EmailListUpdateOptions
                );

            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Deletes the email list by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        public async Task DeleteEmailListById(string id)
        {
            var emailListId = new Guid(id);
            await _emailListService.DeleteByIdAsync(emailListId);
        }


        /// <summary>
        /// Deletes the email list by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        public async Task DeleteEmailListByEmail(string email)
        {
            await _emailListService.DeleteByEmailAsync(email);
        }
    }
}
