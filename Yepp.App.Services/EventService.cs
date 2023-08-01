using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class EventService : IEventService
    {
        private readonly IEventEntityStore _eventEntityStore;
        private readonly IGiftEntityStore _giftEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventService"/> class.
        /// </summary>
        /// <param name="eventEntityStore">The event entity store.</param>
        public EventService(IEventEntityStore eventEntityStore, IGiftEntityStore giftEntityStore)
        {
            _eventEntityStore = eventEntityStore;
            _giftEntityStore = giftEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventAddOptions">The event add options.</param>
        /// <returns></returns>
        public async Task<Event> AddAsync(EventAddOptions eventAddOptions)
        {
            var eventEntity = new EventEntity
            {
                CategoryId = eventAddOptions.CategoryId,
                CreatedDate = DateTime.UtcNow,
                EndDate = eventAddOptions.EndDate,
                Image = eventAddOptions.Image,
                StatusId = eventAddOptions.StatusId,
                TotalBalance = eventAddOptions.TotalBalance,
                UserId = eventAddOptions.UserId,
                Title = eventAddOptions.Title,
                Description = eventAddOptions.Description
            };

            eventEntity = await _eventEntityStore.AddAsync(eventEntity);

            var _event = new Event(eventEntity);

            return _event;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _giftEntityStore.DeleteGiftListByEventId(guid);
            await _eventEntityStore.DeleteByIdAsync(guid);
        }

        public async Task DeleteEventListByUserId(Guid userId)
        {
            var userEventList = await _eventEntityStore.GetEventByUserId(userId);
            
            for (int i = 0; i < userEventList.Count; i++)
            {
                var _event = userEventList[i];
                await DeleteByIdAsync(_event.Id);
            }
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<Event> GetDetail(Guid guid)
        {
            var eventEntity = await _eventEntityStore.GetDetail(guid);
            var _event = new Event(eventEntity);
            return _event;
        }

        /// <summary>
        /// Gets the event by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Event>> GetEventByUserId(Guid userId)
        {
            var userEventList = await _eventEntityStore.GetEventByUserId(userId);

            return
                userEventList.Select(x => new Event(x));
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Event>> ListAsync()
        {
            var eventEntityList = await _eventEntityStore.ListAsync();
            var eventList = eventEntityList.Select(x => new Event(x));

            return eventList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="eventUpdateOptions">The event update options.</param>
        /// <returns></returns>
        public async Task<Event> UpdateByIdAsync(Guid guid, EventUpdateOptions eventUpdateOptions)
        {
            var eventEntity = await _eventEntityStore.FetchByIdAsync(guid);
            eventEntity.EndDate = eventUpdateOptions.EndDate;
            eventEntity.StatusId = eventUpdateOptions.StatusId;
            eventEntity.Image = eventUpdateOptions.Image;
            eventEntity.Title = eventUpdateOptions.Title;
            eventEntity.Description = eventUpdateOptions.Description;
            eventEntity.TotalBalance = eventUpdateOptions.TotalBalance;
            eventEntity.UpdatedDate = DateTime.UtcNow;
            eventEntity.CategoryId = eventUpdateOptions.CategoryId;
            eventEntity.UserId = eventUpdateOptions.UserId;
            eventEntity.payment = eventUpdateOptions.payment;
            eventEntity.payuPaymentReference = eventUpdateOptions.payuPaymentReference;

            eventEntity = await _eventEntityStore.UpdateByIdAsync(guid, eventEntity);

            var _event = new Event(eventEntity);

            return _event;
        }
    }
}
