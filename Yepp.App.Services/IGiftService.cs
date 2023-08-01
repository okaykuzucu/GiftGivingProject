using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IGiftService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="giftAddOptions">The gift add options.</param>
        /// <returns>Gift</returns>
        Task<Gift> AddAsync(GiftAddOptions giftAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="giftUpdateOptions">The gift update options.</param>
        /// <returns></returns>
        Task<Gift> UpdateByIdAsync(Guid guid, GiftUpdateOptions giftUpdateOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns>Gift List</returns>
        Task<IEnumerable<Gift>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">Gift</param>
        /// <returns></returns>
        Task<Gift> GetDetail(Guid guid);

        /// <summary>
        /// Gets the list by event identifier.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<Gift>> GetListByEventId(Guid eventId);

        /// <summary>
        /// Deletes the gift list by event identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task DeleteGiftListByEventId(Guid Id);
    }
}