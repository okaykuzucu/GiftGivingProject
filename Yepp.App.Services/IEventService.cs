using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IEventService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventAddOptions">The event add options.</param>
        /// <returns></returns>
        Task<Event> AddAsync(EventAddOptions eventAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="eventUpdateOptions">The event update options.</param>
        /// <returns></returns>
        Task<Event> UpdateByIdAsync(Guid guid, EventUpdateOptions eventUpdateOptions);

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
        Task<IEnumerable<Event>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<Event> GetDetail(Guid guid);

        /// <summary>
        /// Gets the event by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<Event>> GetEventByUserId(Guid userId);

        /// <summary>
        /// Deletes the event list by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task DeleteEventListByUserId(Guid userId);
    }
}
