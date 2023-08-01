using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class EventNotificationService : IEventNotificationService
    {
        /// <summary>
        /// The event notification entity store
        /// </summary>
        private readonly IEventNotificationEntityStore _eventNotificationEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventNotificationService"/> class.
        /// </summary>
        /// <param name="eventNotificationEntityStore">The event notification entity store.</param>
        public EventNotificationService(IEventNotificationEntityStore eventNotificationEntityStore)
        {
            _eventNotificationEntityStore = eventNotificationEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventNotificationAddOptions">The event notification add options.</param>
        /// <returns></returns>
        public async Task<EventNotification> AddAsync(EventNotificationAddOptions eventNotificationAddOptions)
        {
            var eventNotificationEntity = new EventNotificationEntity
            {
                CreatedDate = DateTime.Now,
                ToUserId = eventNotificationAddOptions.ToUserId,
                EventId = eventNotificationAddOptions.EventId,
                Balance = eventNotificationAddOptions.Balance,
                FromUserId = eventNotificationAddOptions.FromUserId,
                GiftId = eventNotificationAddOptions.GiftId,
                Name = eventNotificationAddOptions.Name,
                StatusId = eventNotificationAddOptions.StatusId,
                UpdatedDate = DateTime.Now

            };
            eventNotificationEntity = await _eventNotificationEntityStore.AddAsync(eventNotificationEntity);
            var eventNotification = new EventNotification(eventNotificationEntity);

            return eventNotification;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _eventNotificationEntityStore.DeleteByIdAsync(guid);

        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EventNotification> GetDetail(Guid guid)
        {
            var eventNotificationEntity = await _eventNotificationEntityStore.FetchByIdAsync(guid);
            var eventNotification = new EventNotification(eventNotificationEntity);

            return eventNotification;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventNotification>> ListAsync()
        {
            var eventNotificationEntityList = await _eventNotificationEntityStore.ListAsync();
            var eventNotificationList = eventNotificationEntityList.Select(x => new EventNotification(x));

            return eventNotificationList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="eventNotificationUpdateOptions">The event notification update options.</param>
        /// <returns></returns>
        public async Task<EventNotification> UpdateByIdAsync(Guid guid, EventNotificationUpdateOptions eventNotificationUpdateOptions)
        {
            var eventNotificationEntity = await _eventNotificationEntityStore.FetchByIdAsync(guid);
            eventNotificationEntity.Balance = eventNotificationUpdateOptions.Balance;
            eventNotificationEntity.CreatedDate = DateTime.UtcNow;
            eventNotificationEntity.EventId = eventNotificationUpdateOptions.EventId;
            eventNotificationEntity.UpdatedDate = DateTime.UtcNow;
            eventNotificationEntity.FromUserId = eventNotificationUpdateOptions.FromUserId;
            eventNotificationEntity.GiftId = eventNotificationUpdateOptions.GiftId;
            eventNotificationEntity.Name = eventNotificationUpdateOptions.Name;
            eventNotificationEntity.StatusId = eventNotificationUpdateOptions.StatusId;
            eventNotificationEntity.ToUserId = eventNotificationUpdateOptions.ToUserId;

            eventNotificationEntity = await _eventNotificationEntityStore.UpdateByIdAsync(guid, eventNotificationEntity);

            var eventNotification = new EventNotification(eventNotificationEntity);

            return eventNotification;
        }
    }
}
