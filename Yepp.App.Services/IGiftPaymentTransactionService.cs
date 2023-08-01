using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IGiftPaymentTransactionService
    {

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="giftPaymentTransactionAddOptions">The gift payment transaction add options.</param>
        /// <returns></returns>
        Task<GiftPaymentTransaction> AddAsync(GiftPaymentTransactionAddOptions giftPaymentTransactionAddOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<GiftPaymentTransaction> GetDetail(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<GiftPaymentTransaction>> ListAsync();

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="giftPaymentTransactionUpdateOptions">The gift payment transaction update options.</param>
        /// <returns></returns>
        Task<GiftPaymentTransaction> UpdateByIdAsync(Guid guid, GiftPaymentTransactionUpdateOptions giftPaymentTransactionUpdateOptions);

        /// <summary>
        /// Gets the deail by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<GiftPaymentTransaction> GetDetailById(Guid id);

        /// <summary>
        /// Gets the deail by gift identifier.
        /// </summary>
        /// <param name="giftId">The gift identifier.</param>
        /// <returns></returns>
        Task<GiftPaymentTransaction> GetDetailByGiftId(Guid giftId);
    }
}
