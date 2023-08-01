using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.IEntityStore{Yepp.App.Entities.Models.GiftEntity}" />
    public interface IGiftEntityStore : IEntityStore<GiftEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<GiftEntity> GetDetail(Guid guid);

        /// <summary>
        /// Gets the list by event identifier.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<List<GiftEntity>> GetListByEventId(Guid eventId);

        /// <summary>
        /// Deletes the gift list by event identifier.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteGiftListByEventId(Guid guid);
    }
}
