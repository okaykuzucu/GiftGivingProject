using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IAcceptedMarketplacesService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="acceptedMarketplacesAddOptions">The accepted marketplaces add options.</param>
        /// <returns></returns>
        Task<AcceptedMarketplaces> AddAsync(AcceptedMarketplacesAddOptions acceptedMarketplacesAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="acceptedMarketplacesUpdateOptions">The accepted marketplaces update options.</param>
        /// <returns></returns>
        Task<AcceptedMarketplaces> UpdateByIdAsync(Guid guid, AcceptedMarketplacesUpdateOptions acceptedMarketplacesUpdateOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid id);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<AcceptedMarketplaces>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<AcceptedMarketplaces> GetDetail(Guid guid);


    }
}