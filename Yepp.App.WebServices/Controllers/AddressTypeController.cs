using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Yepp.App.Bussines.Securities;
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
    public class AddressTypeController : ControllerBase
    {
        private readonly IAddressTypeService _addressTypeService;
        private readonly IDataSecurity _dataSecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTypeController"/> class.
        /// </summary>
        /// <param name="addressTypeService">The address type service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public AddressTypeController(
            IAddressTypeService addressTypeService,
            IDataSecurity dataSecurity
            )
        {
            _addressTypeService = addressTypeService;
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
            var _result = await _addressTypeService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the type of the address.
        /// </summary>
        /// <param name="addressTypeAddOptions">The address type add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddAddressType(AddressTypeAddOptions addressTypeAddOptions)
        {

            var _result = await _addressTypeService.AddAsync(addressTypeAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="addressTypeUpdateDto">The address type update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateAddressType(AddressTypeUpdateDto addressTypeUpdateDto)
        {

            var _result = await _addressTypeService.UpdateByIdAsync(
                new Guid(addressTypeUpdateDto.Id),
                addressTypeUpdateDto.AddressTypeUpdateOptions
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
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<AddressType> GetDetailAddressType(string guid)
        {

            return await _addressTypeService.GetDetail(new Guid(guid));
        }
    }
}
