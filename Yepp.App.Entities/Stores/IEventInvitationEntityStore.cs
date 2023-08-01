using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.IEntityStore{Yepp.App.Entities.Models.EventInvitationEntity}" />
    public interface IEventInvitationEntityStore : IEntityStore<EventInvitationEntity>
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<EventInvitationEntity> GetDetail(Guid guid);

        /// <summary>
        /// Gets the event invitation by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<List<EventInvitationEntity>> GetEventInvitationByUserId(Guid userId);

        /// <summary>
        /// Gets the detail by tracking number.
        /// </summary>
        /// <param name="trackingNumber">The tracking number.</param>
        /// <returns></returns>
        Task<EventInvitationEntity> GetDetailByTrackingNumber(string trackingNumber);
    }
}