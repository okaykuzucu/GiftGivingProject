using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface IEventStatusService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventStatusAddOptions">The event status add options.</param>
        /// <returns></returns>
        Task<EventStatus> AddAsync(EventStatusAddOptions eventStatusAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="gud">The gud.</param>
        /// <param name="eventStatusUpdateOptions">The event status update options.</param>
        /// <returns></returns>
        Task<EventStatus> UpdateByIdAsync(Guid guid, EventStatusUpdateOptions eventStatusUpdateOptions);

        /// <summary>
        /// Delets the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeletByIdAsync(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<EventStatus>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<EventStatus> GetDetail(Guid guid);
    }
}