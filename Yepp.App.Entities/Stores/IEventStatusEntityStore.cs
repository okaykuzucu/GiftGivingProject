using System;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.IEntityStore{Yepp.App.Entities.Models.EventStatusEntity}" />
    public interface IEventStatusEntityStore :IEntityStore<EventStatusEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<EventEntity> GetDetail(Guid guid);
    }
}
