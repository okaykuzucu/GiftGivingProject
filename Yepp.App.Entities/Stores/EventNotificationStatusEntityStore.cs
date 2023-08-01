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
    /// <seealso cref="Yepp.App.Entities.Stores.IEventNotificationStatusEntityStore" />
    public class EventNotificationStatusEntityStore : BaseEntityStore, IEventNotificationStatusEntityStore
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EventNotificationStatusEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public EventNotificationStatusEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }


        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventNotificationStatusEntity> AddAsync(EventNotificationStatusEntity document)
        {
            await _dbContext.EventNotificationStatuses.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var userEntity =
                await _dbContext.EventNotificationStatuses.FindAsync(id);
            if (userEntity != null)
            {
                _dbContext.EventNotificationStatuses.Remove(userEntity);
                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<EventNotificationStatusEntity> FetchByIdAsync(Guid id)
        {
            var eventNotificationStatusEntity =
                await _dbContext.EventNotificationStatuses.FindAsync(id);

            return eventNotificationStatusEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EventNotificationStatusEntity> GetDetail(Guid guid)
        {
            var eventNotificationStatusEntity = await _dbContext.EventNotificationStatuses.Where(x=> x.Id == guid).FirstOrDefaultAsync();

            return eventNotificationStatusEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventNotificationStatusEntity>> ListAsync()
        {
            var eventNotificationStatusEntity =
                 await _dbContext.EventNotificationStatuses.ToListAsync();

            return eventNotificationStatusEntity;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventNotificationStatusEntity> UpdateByIdAsync(Guid id, EventNotificationStatusEntity document)
        {
            var eventNotificationStatusEntityToUpdate =
            await _dbContext.EventNotificationStatuses.FindAsync(id);
            eventNotificationStatusEntityToUpdate.Id = document.Id;
            eventNotificationStatusEntityToUpdate.Name = document.Name;

            try
            {

                await Task.Run(() => _dbContext.EventNotificationStatuses.Update(eventNotificationStatusEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return eventNotificationStatusEntityToUpdate;
        }
    }
}
