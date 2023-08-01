using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public class ReturningUsersFromEventInvitationEntityStore : BaseEntityStore , IReturningUsersFromEventInvitationEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturningUsersFromEventInvitationEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public ReturningUsersFromEventInvitationEntityStore(EntitiesDbContext dbContext)
         : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<ReturningUsersFromEventInvitationEntity> AddAsync(ReturningUsersFromEventInvitationEntity document)
        {
            await _dbContext.ReturningUsersFromEventInvitations.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var returningUsersFromEventInvitationEntity =
                await _dbContext.ReturningUsersFromEventInvitations.FindAsync(id);
            if (returningUsersFromEventInvitationEntity != null)
            {
                _dbContext.ReturningUsersFromEventInvitations.Remove(returningUsersFromEventInvitationEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<ReturningUsersFromEventInvitationEntity> FetchByIdAsync(Guid id)
        {
            var returningUsersFromEventInvitationEntity =
                 await _dbContext.ReturningUsersFromEventInvitations.FindAsync(id);

            return returningUsersFromEventInvitationEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="returningUsersFromEventId">The returning users from event identifier.</param>
        /// <returns></returns>
        public async Task<ReturningUsersFromEventInvitationEntity> GetDetail(Guid returningUsersFromEventId)
        {
            var returningUsersFromEventInvitationEntity = await _dbContext.ReturningUsersFromEventInvitations.Where(x => x.Id == returningUsersFromEventId).FirstOrDefaultAsync();

            return returningUsersFromEventInvitationEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ReturningUsersFromEventInvitationEntity>> ListAsync()
        {
            var returningUsersFromEventInvitationEntityList = await _dbContext.ReturningUsersFromEventInvitations.ToListAsync();

            return returningUsersFromEventInvitationEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<ReturningUsersFromEventInvitationEntity> UpdateByIdAsync(Guid id, ReturningUsersFromEventInvitationEntity document)
        {
            var returningUsersFromEventInvitationEntityToUpdate =
            await _dbContext.ReturningUsersFromEventInvitations.FindAsync(id);
            returningUsersFromEventInvitationEntityToUpdate.CreatedDate = DateTime.UtcNow;
            returningUsersFromEventInvitationEntityToUpdate.InvitationChannelId = document.InvitationChannelId;
            returningUsersFromEventInvitationEntityToUpdate.Id = document.Id;
            returningUsersFromEventInvitationEntityToUpdate.UpdatedDate = DateTime.UtcNow;
            returningUsersFromEventInvitationEntityToUpdate.UserId = document.UserId;
            returningUsersFromEventInvitationEntityToUpdate.TrackingNumber=document.TrackingNumber;

            try
            {

                await Task.Run(() => _dbContext.ReturningUsersFromEventInvitations.Update(returningUsersFromEventInvitationEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return returningUsersFromEventInvitationEntityToUpdate;

        }
    }
}
