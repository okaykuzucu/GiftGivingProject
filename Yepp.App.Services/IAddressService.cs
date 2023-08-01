using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IAddressService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="addressAddOptions">The address add options.</param>
        /// <returns></returns>
        Task<Address> AddAsync(AddressAddOptions addressAddOptions);

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
        Task<Address> GetDetail(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Address>> ListAsync();

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="addressUpdateOptions">The address update options.</param>
        /// <returns></returns>
        Task<Address> UpdateByIdAsync(Guid guid, AddressUpdateOptions addressUpdateOptions);


        /// <summary>
        /// Gets the user by addresses.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<Address>> GetUserByAddresses(Guid userId);

    }
}
