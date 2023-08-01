using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IEventNotificationService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventNotificationAddOptions">The event notification add options.</param>
        /// <returns></returns>
        Task<EventNotification> AddAsync(EventNotificationAddOptions eventNotificationAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="eventNotificationUpdateOptions">The event notification update options.</param>
        /// <returns></returns>
        Task<EventNotification> UpdateByIdAsync(Guid guid, EventNotificationUpdateOptions eventNotificationUpdateOptions);

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
        Task<EventNotification> GetDetail(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<EventNotification>> ListAsync();
    }
}