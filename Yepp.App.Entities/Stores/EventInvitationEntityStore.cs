using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{

    /// <summary>
    /// the role entity store
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.Stores.IEventInvitationEntityStore" />
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.IGiftPaymentTransactionEntityStore" />
    public class EventInvitationEntityStore : BaseEntityStore, IEventInvitationEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressEntityStore" /> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public EventInvitationEntityStore(EntitiesDbContext dbContext)
         : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventInvitationEntity> AddAsync(EventInvitationEntity document)
        {
            await _dbContext.EventInvitations.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;

        }




        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var eventInvitationEntity =
                await _dbContext.EventInvitations.FindAsync(id);
            if (eventInvitationEntity != null)
            {
                _dbContext.EventInvitations.Remove(eventInvitationEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<EventInvitationEntity> FetchByIdAsync(Guid id)
        {
            var eventInvitationEntity =
                await _dbContext.EventInvitations.FindAsync(id);

            return eventInvitationEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<EventInvitationEntity> GetDetail(Guid guid)
        {
            var eventInvitationEntity = await _dbContext.EventInvitations.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return eventInvitationEntity;
        }

        /// <summary>
        /// Gets the detail by tracking number.
        /// </summary>
        /// <param name="trackingNumber">The tracking number.</param>
        /// <returns></returns>
        public async Task<EventInvitationEntity> GetDetailByTrackingNumber(string trackingNumber)
        {                   
            var eventInvitationEntity = await _dbContext.EventInvitations.Where(x => x.TrackingNumber == trackingNumber).FirstOrDefaultAsync();

            return eventInvitationEntity;           
        }


        /// <summary>
        /// Gets the event invitation by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<List<EventInvitationEntity>> GetEventInvitationByUserId(Guid userId)
        {
            return
               await _dbContext.EventInvitations.Where(x => x.UserId == userId).ToListAsync();
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventInvitationEntity>> ListAsync()
        {
            var eventInvitationEntityList =
                await _dbContext.EventInvitations.ToListAsync();

            return eventInvitationEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<EventInvitationEntity> UpdateByIdAsync(Guid id, EventInvitationEntity document)
        {
            var eventInvitationEntityToUpdate =
            await _dbContext.EventInvitations.FindAsync(id);
            eventInvitationEntityToUpdate.TrackingNumber = document.TrackingNumber;
            eventInvitationEntityToUpdate.CreatedDate = DateTime.UtcNow;
            eventInvitationEntityToUpdate.EventId = document.EventId;
            eventInvitationEntityToUpdate.InvitationChannelId = document.InvitationChannelId;
            eventInvitationEntityToUpdate.Link = document.Link;
            eventInvitationEntityToUpdate.UserId = document.UserId;
            eventInvitationEntityToUpdate.UpdatedDate = DateTime.UtcNow;

            try
            {

                await Task.Run(() => _dbContext.EventInvitations.Update(eventInvitationEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return eventInvitationEntityToUpdate;

        }
    }
}
