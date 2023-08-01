using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IEventInvitationService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventInvitationAddOptions">The event invitation add options.</param>
        /// <returns></returns>
        Task<EventInvitation> AddAsync(EventInvitationAddOptions eventInvitationAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="eventInvitationUpdateOptions">The event invitation update options.</param>
        /// <returns></returns>
        Task<EventInvitation> UpdateByIdAsync(Guid guid, EventInvitationUpdateOptions eventInvitationUpdateOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<EventInvitation>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<EventInvitation> GetDetail(Guid guid);

        /// <summary>
        /// Gets the event invitation by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<EventInvitation>> GetEventInvitationByUserId(Guid userId);

        /// <summary>
        /// Gets the detail by tracking number.
        /// </summary>
        /// <param name="trackingNumber">The tracking number.</param>
        /// <returns></returns>
        Task<EventInvitation> GetDetailByTrackingNumber(string trackingNumber);
    }

}
