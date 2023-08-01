using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;


namespace Yepp.App.Services
{
    public class EventStatusService : IEventStatusService
    {
        private readonly IEventStatusEntityStore _eventStatusEntityStore;

        public EventStatusService(IEventStatusEntityStore eventStatusEntityStore)
        {
            _eventStatusEntityStore = eventStatusEntityStore;
        }
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventStatusAddOptions">The event status add options.</param>
        /// <returns></returns>
        public async Task<EventStatus> AddAsync(EventStatusAddOptions eventStatusAddOptions)
        {
            var eventStatusEntity = new EventStatusEntity
            {
                Name = eventStatusAddOptions.Name,
            };
            eventStatusEntity = await _eventStatusEntityStore.AddAsync(eventStatusEntity);

            var _eventStatus = new EventStatus(eventStatusEntity);

            return _eventStatus;
        }

        /// <summary>
        /// Delets the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeletByIdAsync(Guid guid)
        {
            await _eventStatusEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EventStatus> GetDetail(Guid guid)
        {
            var eventStatusEntity = await _eventStatusEntityStore.FetchByIdAsync(guid);
            var _eventStatus = new EventStatus(eventStatusEntity);

            return  _eventStatus;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventStatus>> ListAsync()
        {
            var eventStatusEntityList = await _eventStatusEntityStore.ListAsync();
            var eventStatusList = eventStatusEntityList.Select(x => new EventStatus(x));

            return eventStatusList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="eventStatusUpdateOptions">The event status update options.</param>
        /// <returns></returns>
        public async Task<EventStatus> UpdateByIdAsync(Guid guid, EventStatusUpdateOptions eventStatusUpdateOptions)
        {
            var eventStatusEntity = await _eventStatusEntityStore.FetchByIdAsync(guid);
            eventStatusEntity.Name = eventStatusUpdateOptions.Name;

            eventStatusEntity = await _eventStatusEntityStore.UpdateByIdAsync(guid, eventStatusEntity);

            var _eventStatus = new EventStatus(eventStatusEntity);

            return _eventStatus;
        }
    }
}
