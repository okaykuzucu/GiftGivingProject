using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;


namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.IEventStatusEntityStore" />
    public class EventStatusEntityStore : BaseEntityStore, IEventStatusEntityStore
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EventStatusEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public EventStatusEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventStatusEntity> AddAsync(EventStatusEntity document)
        {
            await _dbContext.Event_Status.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var eventStatusEntity =
             await _dbContext.Event_Status.FindAsync(id);
            if (eventStatusEntity != null)
            {
                _dbContext.Event_Status.Remove(eventStatusEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<EventStatusEntity> FetchByIdAsync(Guid id)
        {
            var EventStatusEntity =
                await _dbContext.Event_Status.FindAsync(id);

            return EventStatusEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<EventEntity> GetDetail(Guid guid)
        {
            //bunu yapamadım.
            throw new NotImplementedException();
        }


        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventStatusEntity>> ListAsync()
        {
            var eventStatusEntity = await _dbContext.Event_Status.ToListAsync();
            
            return eventStatusEntity;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventStatusEntity> UpdateByIdAsync(Guid id, EventStatusEntity document)
        {
            var eventStatusEntityToUpdate =
            await _dbContext.Event_Status.FindAsync(id);
            eventStatusEntityToUpdate.Name = document.Name;

            try
            {

                await Task.Run(() => _dbContext.Event_Status.Update(eventStatusEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return eventStatusEntityToUpdate;

        }
    }
}
