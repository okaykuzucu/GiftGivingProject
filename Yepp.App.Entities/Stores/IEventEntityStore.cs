using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.IEntityStore{Yepp.App.Entities.Models.EventEntity}" />
    public interface  IEventEntityStore : IEntityStore<EventEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<EventEntity> GetDetail(Guid guid);

        /// <summary>
        /// Gets the event by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<List<EventEntity>> GetEventByUserId(Guid userId);

    }
}
