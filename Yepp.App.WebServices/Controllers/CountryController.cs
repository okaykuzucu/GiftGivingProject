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
    public class CountryController : ControllerBase
    {

        private readonly ICountryService _countryService;
        private readonly IDataSecurity _dataSecurity;


        /// <summary>
        /// Initializes a new instance of the <see cref="CountryController"/> class.
        /// </summary>
        /// <param name="countryService">The country service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public CountryController(
            ICountryService countryService,
            IDataSecurity dataSecurity
            )
        {
            _countryService = countryService;
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
            var _result = await _countryService.ListAsync();

            if (_result == null)
            {
                return new ObjectResult("null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden };
            }

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the country.
        /// </summary>
        /// <param name="countryAddOptions">The country add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddCountry(CountryAddOptions countryAddOptions)
        {

            var _result = await _countryService.AddAsync(countryAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };

            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };

        }

        /// <summary>
        /// Updates the country.
        /// </summary>
        /// <param name="countryUpdateDto">The country update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateCountry(CountryUpdateDto countryUpdateDto)
        {

            var _result = await _countryService.UpdateByIdAsync(
                new Guid(countryUpdateDto.Id),
                countryUpdateDto.CountryUpdateOptions
                );
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }


        /// <summary>
        /// Gets the detail country.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<Country> GetDetailCountry(string guid)
        {

            return await _countryService.GetDetail(new Guid(guid));
        }
    }
}
