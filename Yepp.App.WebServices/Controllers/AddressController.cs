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
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly IDataSecurity _dataSecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressController"/> class.
        /// </summary>
        /// <param name="addressService">The address service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public AddressController(
            IAddressService addressService,
            IDataSecurity dataSecurity
            )
        {
            _addressService = addressService;
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
            var _result = await _addressService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the address.
        /// </summary>
        /// <param name="addressAddOptions">The address add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddAddress(AddressAddOptions addressAddOptions)
        {

            var _result = await _addressService.AddAsync(addressAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Updates the address.
        /// </summary>
        /// <param name="addressUpdateDto">The address update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateAddress(AddressUpdateDto addressUpdateDto)
        {
            var _result = await _addressService.UpdateByIdAsync(
                new Guid(addressUpdateDto.Id),
                addressUpdateDto.AddressUpdateOptions
                );
            if (_result==null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

                return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

        }


        /// <summary>
        /// Gets the detail address.
        /// </summary>
        /// <param name="userDetailDto">The user detail dto.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> GetByUserAddressList(UserDetailDto userDetailDto)
        {

            var resultList = await _addressService.GetUserByAddresses(new Guid(userDetailDto.UserId));
           
            return 
                new ObjectResult(resultList) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }
    }
}
