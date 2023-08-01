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
    /// <seealso cref="Yepp.App.Entities.Stores.IEventEntityStore" />
    public class EventEntityStore : BaseEntityStore, IEventEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public EventEntityStore(EntitiesDbContext dbContext)
               : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventEntity> AddAsync(EventEntity document)
        {
            await _dbContext.Events.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async  Task DeleteByIdAsync(Guid id)
        {

            var eventEntity =
              await _dbContext.Events.FindAsync(id);

            if (eventEntity != null)
            {
                _dbContext.Events.Remove(eventEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<EventEntity> FetchByIdAsync(Guid id)
        {
            
            var eventEntity =
            await _dbContext.Events.FindAsync(id);

            return eventEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EventEntity> GetDetail(Guid guid)
        {
            var eventEntity = await _dbContext.Events.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return eventEntity;
        }

        /// <summary>
        /// Gets the event by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<List<EventEntity>> GetEventByUserId(Guid userId)
        {
           return 
                await _dbContext.Events.Where(x => x.UserId == userId).ToListAsync();
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventEntity>> ListAsync()
        {
            var eventEntityList =
            await _dbContext.Events.ToListAsync();

            return eventEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventEntity> UpdateByIdAsync(Guid id, EventEntity document)
        {
            var eventEntityToUpdate =
            await _dbContext.Events.FindAsync(id);
            eventEntityToUpdate.CategoryId = document.CategoryId;
            eventEntityToUpdate.EndDate = document.EndDate;
            eventEntityToUpdate.Id = document.Id;
            eventEntityToUpdate.Image = document.Image;
            eventEntityToUpdate.StatusId = document.StatusId;
            eventEntityToUpdate.TotalBalance = document.TotalBalance;
            eventEntityToUpdate.UserId = document.UserId;
            eventEntityToUpdate.UpdatedDate = DateTime.UtcNow;
            eventEntityToUpdate.Description = document.Description;
            eventEntityToUpdate.Title = document.Title;
            eventEntityToUpdate.payment = document.payment;
            eventEntityToUpdate.payuPaymentReference = document.payuPaymentReference;
            await _dbContext.SaveChangesAsync();

            try
            {

                await Task.Run(() => _dbContext.Events.Update(eventEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return eventEntityToUpdate;
        }
    }
}
