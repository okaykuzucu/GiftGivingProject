using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IEventNotificationStatusService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventNotificationAddOptions">The event notification add options.</param>
        /// <returns></returns>
        Task<EventNotificationStatus> AddAsync(EventNotificationStatusAddOptions eventNotificationStatusAddOptions);

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
        Task<EventNotificationStatus> GetDetail(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<EventNotificationStatus>> ListAsync();

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="eventNotificationUpdateOptions">The event notification update options.</param>
        /// <returns></returns>
        Task<EventNotificationStatus> UpdateByIdAsync(Guid guid, EventNotificationStatusUpdateOptions eventNotificationStatusUpdateOptions);

        /// <summary>
        /// Gets the user by addresses.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<EventNotificationStatus>> GetUserByAddresses(Guid userId);
    }
}
