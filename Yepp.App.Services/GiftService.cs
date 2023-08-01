using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class GiftService : IGiftService
    {
        private readonly IGiftEntityStore _giftEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService" /> class.
        /// </summary>
        /// <param name="giftEntityStore">The gift entity store.</param>
        public GiftService(IGiftEntityStore giftEntityStore)
        {
            _giftEntityStore = giftEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="giftAddOptions">The gift add options.</param>
        /// <returns>
        /// Gift
        /// <returns></returns>
        public async Task<Gift> AddAsync(GiftAddOptions giftAddOptions)
        {
            

            var giftEntity = new GiftEntity
            {
                CreatedDate = DateTime.UtcNow,
                Description = giftAddOptions.Description,
                EventId = giftAddOptions.EventId,
                Image = giftAddOptions.Image,
                Link = giftAddOptions.Link,
                Name = giftAddOptions.Name,
                Price = giftAddOptions.Price,
                PriorityId = new Guid(giftAddOptions.PriorityId),
                Quantity = giftAddOptions.Quantity,
            };

            giftEntity = await _giftEntityStore.AddAsync(giftEntity);

            var gift = new Gift(giftEntity);

            return gift;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _giftEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<Gift> GetDetail(Guid guid)
        {
            var giftEntity = await _giftEntityStore.GetDetail(guid);
            var gift = new Gift(giftEntity);

            return gift;
        }

        /// <summary>
        /// Gets the list by event identifier.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Gift>> GetListByEventId(Guid eventId)
        {
            var giftEventList = await _giftEntityStore.GetListByEventId(eventId);

            return
                giftEventList.Select(x => new Gift(x));
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Gift>> ListAsync()
        {
            var giftEntityList = await _giftEntityStore.ListAsync();
            var giftList = giftEntityList.Select(x => new Gift(x));

            return giftList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="giftUpdateOptions">The gift update options.</param>
        /// <returns></returns>
        public async Task<Gift> UpdateByIdAsync(Guid guid, GiftUpdateOptions giftUpdateOptions)
        {
            var giftEntity = await _giftEntityStore.FetchByIdAsync(guid);
            giftEntity.Description = giftUpdateOptions.Description;
            giftEntity.EventId = giftUpdateOptions.EventId;
            giftEntity.Image = giftUpdateOptions.Image;
            giftEntity.Link = giftUpdateOptions.Link;
            giftEntity.Name = giftUpdateOptions.Name;
            giftEntity.Price = giftUpdateOptions.Price;
            giftEntity.PriorityId = giftUpdateOptions.PriorityId;
            giftEntity.Quantity = giftUpdateOptions.Quantity;
            giftEntity.UpdatedDate = DateTime.UtcNow;

            giftEntity = await _giftEntityStore.UpdateByIdAsync(guid, giftEntity);

            var gift = new Gift(giftEntity);

            return gift;
        }

        /// <summary>
        /// Deletes the gift list by event identifier.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteGiftListByEventId (Guid guid)
        {
            await _giftEntityStore.DeleteGiftListByEventId(guid);
        }
    }
}