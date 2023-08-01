using System;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public interface IPriorityEntityStore : IEntityStore<PriorityEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<PriorityEntity> GetDetail(Guid guid);
    }
}
