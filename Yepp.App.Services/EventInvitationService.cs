using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;
using System.Linq;
using Yepp.App.Entities.Models;


namespace Yepp.App.Services
{
    public class EventInvitationService : IEventInvitationService
    {
        private readonly IEventInvitationEntityStore _eventInvitationEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventInvitationService"/> class.
        /// </summary>
        /// <param name="eventInvitationEntityStore">The event invitation entity store.</param>
        public EventInvitationService(IEventInvitationEntityStore eventInvitationEntityStore)
        {
            _eventInvitationEntityStore = eventInvitationEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="eventInvitationAddOptions">The event invitation add options.</param>
        /// <returns></returns>
        public async Task<EventInvitation> AddAsync(EventInvitationAddOptions eventInvitationAddOptions)
        {
            var eventInvitationEntity = new EventInvitationEntity
            {
                CreatedDate = DateTime.Now,
                UpdatedDate = eventInvitationAddOptions.UpdatedDate,
                EventId = eventInvitationAddOptions.EventId,
                InvitationChannelId = eventInvitationAddOptions.InvitationChannelId,
                Link = eventInvitationAddOptions.Link,
                UserId = eventInvitationAddOptions.UserId,
                TrackingNumber = eventInvitationAddOptions.TrackingNumber
              
            };
            eventInvitationEntity = await _eventInvitationEntityStore.AddAsync(eventInvitationEntity);

            return new EventInvitation(eventInvitationEntity);
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _eventInvitationEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EventInvitation> GetDetail(Guid guid)
        {
            var eventInvitationEntity = await _eventInvitationEntityStore.GetDetail(guid);
            var eventInvitation = new EventInvitation(eventInvitationEntity);

            return eventInvitation;
        }

        /// <summary>
        /// Gets the detail by tracking number.
        /// </summary>
        /// <param name="trackingNumber">The tracking number.</param>
        /// <returns></returns>
        public async Task<EventInvitation> GetDetailByTrackingNumber(string trackingNumber)
        {
            var eventInvitationEntity = await _eventInvitationEntityStore.GetDetailByTrackingNumber(trackingNumber);
            var eventInvitation = new EventInvitation(eventInvitationEntity);

            return eventInvitation;
        }

        /// <summary>
        /// Gets the event invitation list by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<EventInvitation>> GetEventInvitationByUserId(Guid userId)
        {
            var userEventList = await _eventInvitationEntityStore.GetEventInvitationByUserId(userId);

            return
                userEventList.Select(x => new EventInvitation(x));
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventInvitation>> ListAsync()
        {
            var eventInvitationEntityList = await _eventInvitationEntityStore.ListAsync();
            var eventInvitationList = eventInvitationEntityList.Select(x => new EventInvitation(x));

            return eventInvitationList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="eventInvitationUpdateOptions">The event invitation update options.</param>
        /// <returns></returns>
        public async Task<EventInvitation> UpdateByIdAsync(Guid guid, EventInvitationUpdateOptions eventInvitationUpdateOptions)
        {
            var eventInvitationEntity = await _eventInvitationEntityStore.FetchByIdAsync(guid);
            eventInvitationEntity.CreatedDate = eventInvitationUpdateOptions.CreatedDate;
            eventInvitationEntity.EventId = eventInvitationUpdateOptions.EventId;
            eventInvitationEntity.UpdatedDate = eventInvitationUpdateOptions.UpdatedDate;
            eventInvitationEntity.InvitationChannelId = eventInvitationUpdateOptions.InvitationChannelId;
            eventInvitationEntity.Link = eventInvitationUpdateOptions.Link;
            eventInvitationEntity.UserId = eventInvitationUpdateOptions.UserId;
            eventInvitationEntity.TrackingNumber = eventInvitationUpdateOptions.TrackingNumber;

            eventInvitationEntity = await _eventInvitationEntityStore.UpdateByIdAsync(guid, eventInvitationEntity);

            var eventInvitation = new EventInvitation(eventInvitationEntity);

            return eventInvitation;

        }
    }
}
