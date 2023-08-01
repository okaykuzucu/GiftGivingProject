using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class EventNotificationStatusService : IEventNotificationStatusService
    {
        private readonly IEventNotificationStatusEntityStore _eventNotificationStatusEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventNotificationStatusService"/> class.
        /// </summary>
        /// <param name="eventNotificationStatusEntityStore">The event notification status entity store.</param>
        public EventNotificationStatusService(IEventNotificationStatusEntityStore eventNotificationStatusEntityStore)
        {
            _eventNotificationStatusEntityStore = eventNotificationStatusEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventNotificationStatusAddOptions"></param>
        /// <returns></returns>
        public async Task<EventNotificationStatus> AddAsync(EventNotificationStatusAddOptions eventNotificationStatusAddOptions)
        {
            var eventNotificationStatusEntity = new EventNotificationStatusEntity
            {
                Name = eventNotificationStatusAddOptions.Name
            };

            eventNotificationStatusEntity = await _eventNotificationStatusEntityStore.AddAsync(eventNotificationStatusEntity);

            var eventNotificationStatus = new EventNotificationStatus(eventNotificationStatusEntity);

            return eventNotificationStatus;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _eventNotificationStatusEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EventNotificationStatus> GetDetail(Guid guid)
        {
            var eventNotificationStatusEntity = await _eventNotificationStatusEntityStore.GetDetail(guid);

            var eventNotificationStatus = new EventNotificationStatus(eventNotificationStatusEntity);

            return eventNotificationStatus;

        }

        public Task<IEnumerable<EventNotificationStatus>> GetUserByAddresses(Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventNotificationStatus>> ListAsync()
        {
            var eventNotificationStatusEntityList = await _eventNotificationStatusEntityStore.ListAsync();
            var eventNotificationStatusList = eventNotificationStatusEntityList.Select(x => new EventNotificationStatus(x));

            return eventNotificationStatusList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="eventNotificationStatusUpdateOptions"></param>
        /// <returns></returns>
        public async Task<EventNotificationStatus> UpdateByIdAsync(Guid guid, EventNotificationStatusUpdateOptions eventNotificationStatusUpdateOptions)
        {
            var eventNotificationStatusEntity = await _eventNotificationStatusEntityStore.FetchByIdAsync(guid);
            eventNotificationStatusEntity.Name = eventNotificationStatusUpdateOptions.Name;

            eventNotificationStatusEntity = await _eventNotificationStatusEntityStore.UpdateByIdAsync(guid, eventNotificationStatusEntity);

            var eventNotificationStatus = new EventNotificationStatus(eventNotificationStatusEntity);

            return eventNotificationStatus;
        }
    }
}
