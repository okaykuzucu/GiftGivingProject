using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Yepp.App.Services.Models;
using Yepp.App.Services;
using Yepp.App.WebServices.Dtos;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AcceptedMarketplacesController : ControllerBase
    {
        private readonly IAcceptedMarketplacesService _acceptedMarketplacesService;


        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptedMarketplacesController"/> class.
        /// </summary>
        /// <param name="AcceptedMarketplacesService">The accepted marketplaces service.</param>
        public AcceptedMarketplacesController(
            IAcceptedMarketplacesService AcceptedMarketplacesService)
        {
            _acceptedMarketplacesService = AcceptedMarketplacesService;
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetList()
        {
            var _result = await _acceptedMarketplacesService.ListAsync();

            if(_result == null)
            {
                 return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail by accepted marketplaces.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetDetailByAcceptedMarketplaces(string id)
        {
            if (id == null)
            {
                return new ObjectResult("id is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var _result = await _acceptedMarketplacesService.GetDetail(new Guid(id));

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the accepted marketplaces.
        /// </summary>
        /// <param name="acceptedMarketplacesAddOptions">The accepted marketplaces add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddAcceptedMarketplaces(AcceptedMarketplacesAddOptions acceptedMarketplacesAddOptions)
        {
            var _result = await _acceptedMarketplacesService.AddAsync(acceptedMarketplacesAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            return
               new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }
        /// <summary>
        /// Updates the accepted marketplaces.
        /// </summary>
        /// <param name="acceptedMarketplacesUpdateDto">The accepted marketplaces update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public  async Task<IActionResult> UpdateAcceptedMarketplaces(AcceptedMarketplacesUpdateDto acceptedMarketplacesUpdateDto)
        {
            var _result = await _acceptedMarketplacesService.UpdateByIdAsync(
                new Guid(acceptedMarketplacesUpdateDto.Id),
                acceptedMarketplacesUpdateDto.AcceptedMarketplacesUpdatOptions
                );
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Deletes the accepted marketplaces by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete]
        [Authorize]
        public async Task DeleteAcceptedMarketplacesById(string id)
        {
            var acceptedMarketplacesId = new Guid(id);
            await _acceptedMarketplacesService.DeleteByIdAsync(acceptedMarketplacesId);
        }
    }

}
