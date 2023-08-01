using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IAddressTypeService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="addressTypeAddOptions">The address type add options.</param>
        /// <returns></returns>
        Task<AddressType> AddAsync(AddressTypeAddOptions addressTypeAddOptions);

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<AddressType> GetDetail(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<AddressType>> ListAsync();

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="addressTypeUpdateOptions">The address type update options.</param>
        /// <returns></returns>
        Task<AddressType> UpdateByIdAsync(Guid guid, AddressTypeUpdateOptions addressTypeUpdateOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

    }
}
