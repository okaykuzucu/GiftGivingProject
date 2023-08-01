using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public class EventNotificationEntityStore : BaseEntityStore, IEventNotificationEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventNotificationEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public EventNotificationEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventNotificationEntity> AddAsync(EventNotificationEntity document)
        {
            await _dbContext.EventNotifcations.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var eventNotificationEntity =
                await _dbContext.EventNotifcations.FindAsync(id);

            if (eventNotificationEntity != null)
            {
                _dbContext.EventNotifcations.Remove(eventNotificationEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<EventNotificationEntity> FetchByIdAsync(Guid id)
        {
            var eventNotificationEntity =
                await _dbContext.EventNotifcations.FindAsync(id);

            return eventNotificationEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EventNotificationEntity> GetDetail(Guid guid)
        {
            var eventNotificationEntity = await _dbContext.EventNotifcations.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return eventNotificationEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventNotificationEntity>> ListAsync()
        {
            var eventNotificationEntityList =
                await _dbContext.EventNotifcations.ToListAsync();

            return eventNotificationEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventNotificationEntity> UpdateByIdAsync(Guid id, EventNotificationEntity document)
        {
            var eventNotificationEntityToUpdate =
                await _dbContext.EventNotifcations.FindAsync(id);
            eventNotificationEntityToUpdate.CreatedDate = DateTime.UtcNow;
            eventNotificationEntityToUpdate.Balance = eventNotificationEntityToUpdate.Balance;
            eventNotificationEntityToUpdate.EventId = eventNotificationEntityToUpdate.EventId;
            eventNotificationEntityToUpdate.FromUserId = eventNotificationEntityToUpdate.FromUserId;
            eventNotificationEntityToUpdate.GiftId = eventNotificationEntityToUpdate.GiftId;
            eventNotificationEntityToUpdate.Name = eventNotificationEntityToUpdate.Name;
            eventNotificationEntityToUpdate.UpdatedDate = eventNotificationEntityToUpdate.UpdatedDate;
            eventNotificationEntityToUpdate.StatusId = eventNotificationEntityToUpdate.StatusId;
            eventNotificationEntityToUpdate.CreatedDate = eventNotificationEntityToUpdate.CreatedDate;

            try
            {

                await Task.Run(() => _dbContext.EventNotifcations.Update(eventNotificationEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return eventNotificationEntityToUpdate;
        }
      }
    }
