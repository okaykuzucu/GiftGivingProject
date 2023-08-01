using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.IGiftEntityStore" />
    public class GiftEntityStore : BaseEntityStore, IGiftEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GiftEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public GiftEntityStore(EntitiesDbContext dbContext)
         : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<GiftEntity> AddAsync(GiftEntity document)
        {
            await _dbContext.Gifts.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        public async Task DeleteGiftListByEventId(Guid guid)
        {
            _dbContext.Gifts.RemoveRange(_dbContext.Gifts.Where(x => x.EventId == guid));
            await _dbContext.SaveChangesAsync();                       
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var giftEntity =
                await _dbContext.Gifts.FindAsync(id);

            if (giftEntity != null)
            {
                _dbContext.Gifts.Remove(giftEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<GiftEntity> FetchByIdAsync(Guid id)
        {
            var giftEntity =
             await _dbContext.Gifts.FindAsync(id);

            return giftEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<GiftEntity> GetDetail(Guid guid)
        {
            var giftEntity = await _dbContext.Gifts.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return giftEntity;
        }

        /// <summary>
        /// Gets the list by event identifier.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <returns></returns>
        public async Task<List<GiftEntity>> GetListByEventId(Guid eventId)
        {
            return
                await _dbContext.Gifts.Where(x => x.EventId == eventId).ToListAsync();
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GiftEntity>> ListAsync()
        {
            var giftEntityList =
            await _dbContext.Gifts.ToListAsync();

            return giftEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<GiftEntity> UpdateByIdAsync(Guid id, GiftEntity document)
        {
            var giftEntityToUpdate =
            await _dbContext.Gifts.FindAsync(id);
            giftEntityToUpdate.CreatedDate = DateTime.UtcNow;
            giftEntityToUpdate.Description = document.Description;
            giftEntityToUpdate.EventId = document.EventId;
            giftEntityToUpdate.Id = document.Id;
            giftEntityToUpdate.Image = document.Image;
            giftEntityToUpdate.Link = document.Link;
            giftEntityToUpdate.Name = document.Name;
            giftEntityToUpdate.Price = document.Price;
            giftEntityToUpdate.PriorityId = document.PriorityId;
            giftEntityToUpdate.Quantity = document.Quantity;
            giftEntityToUpdate.UpdatedDate = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync();

            try
            {

                await Task.Run(() => _dbContext.Gifts.Update(giftEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return giftEntityToUpdate;
        }
    }
}
