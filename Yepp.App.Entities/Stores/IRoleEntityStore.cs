using System;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{   /// <summary>
    /// The user entity store
    /// </summary>
    /// <seealso cref="Emos.Crypto.Entity.IEntityStore{Yepp.App.Entities.Models.UserEntity}" />
    public interface IRoleEntityStore : IEntityStore<RoleEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<RoleEntity> GetDetail(Guid guid);

    }
}
