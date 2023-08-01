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
    public class GiftPaymentTransactionController : ControllerBase
    {
        private readonly IGiftPaymentTransactionService _giftPaymentTransactionService;
        private readonly IDataSecurity _dataSecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="GiftPaymentTransactionController"/> class.
        /// </summary>
        /// <param name="giftPaymentTransactionService">The gift payment transaction service.</param>
        /// <param name="dataSecurity">The data security.</param>
        public GiftPaymentTransactionController(
            IGiftPaymentTransactionService giftPaymentTransactionService,
            IDataSecurity dataSecurity
           )
        {
            _giftPaymentTransactionService = giftPaymentTransactionService;
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
            var _result = await _giftPaymentTransactionService.ListAsync();

            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetDetailById(Guid id)
        {
            if (id == null)
            {
                return new ObjectResult("id is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var _result = await _giftPaymentTransactionService.GetDetailById(id);
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Gets the detail by gift identifier.
        /// </summary>
        /// <param name="giftId">The gift identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetDetailByGiftId(Guid giftId)
        {
            if (giftId == null)
            {
                return new ObjectResult("giftId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var _result = await _giftPaymentTransactionService.GetDetailByGiftId(giftId);
            return new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Adds the gift payment transaction.
        /// </summary>
        /// <param name="giftPaymentTransactionAddOptions">The gift payment transaction add options.</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddGiftPaymentTransaction(GiftPaymentTransactionAddOptions giftPaymentTransactionAddOptions)
        {

            var _result = await _giftPaymentTransactionService.AddAsync(giftPaymentTransactionAddOptions);
            if (_result == null)
            {
                return
                    new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            return
                new ObjectResult(_result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Updates the gift payment transaction.
        /// </summary>
        /// <param name="giftPaymentTransactionUpdateDto">The gift payment transaction update dto.</param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateGiftPaymentTransaction(GiftPaymentTransactionUpdateDto giftPaymentTransactionUpdateDto)
        {
            var _result = await _giftPaymentTransactionService.UpdateByIdAsync(
                new Guid(giftPaymentTransactionUpdateDto.Id),
                giftPaymentTransactionUpdateDto.GiftPaymentTransactionUpdateOptions
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
