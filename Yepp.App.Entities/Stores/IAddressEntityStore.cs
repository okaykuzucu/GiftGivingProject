using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// The Address Entity Store
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.IEntityStore{Yepp.App.Entities.Models.AddressEntity}" />
    /// <seealso cref="Yepp.App.Entities.IEntityStore{Yepp.App.Entities.Models.AddressTypeEntity}" />
    public interface IAddressEntityStore : IEntityStore<AddressEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<AddressEntity> GetDetail(Guid guid);

        /// <summary>
        /// Gets the user by addresses.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<AddressEntity>> GetUserByAddresses(Guid userId);


    }
}
