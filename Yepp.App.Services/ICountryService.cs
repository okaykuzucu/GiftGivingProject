using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface ICountryService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="countryAddOptions">The country add options.</param>
        /// <returns></returns>
        Task<Country> AddAsync(CountryAddOptions countryAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="countryUpdateOptions">The country update options.</param>
        /// <returns></returns>
        Task<Country> UpdateByIdAsync(Guid guid, CountryUpdateOptions countryUpdateOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Country>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<Country> GetDetail(Guid guid);
    }
}
