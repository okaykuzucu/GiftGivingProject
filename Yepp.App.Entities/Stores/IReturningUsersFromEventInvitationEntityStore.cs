using System;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// 
    /// </summary>
    public interface IReturningUsersFromEventInvitationEntityStore : IEntityStore<ReturningUsersFromEventInvitationEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<ReturningUsersFromEventInvitationEntity> GetDetail(Guid guid);

    }
}
