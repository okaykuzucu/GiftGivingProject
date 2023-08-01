using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface ICityService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="cityAddOptions">The city add options.</param>
        /// <returns></returns>
        Task<City> AddAsync(CityAddOptions cityAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="cityUpdateOptions">The city update options.</param>
        /// <returns></returns>
        Task<City> UpdateByIdAsync(Guid guid, CityUpdateOptions cityUpdateOptions);

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
        Task<IEnumerable<City>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<City> GetDetail(Guid guid);
    }
}
