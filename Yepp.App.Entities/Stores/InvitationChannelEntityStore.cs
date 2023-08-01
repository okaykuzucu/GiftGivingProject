using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Yepp.App.Entities.Stores
{
    public class InvitationChannelEntityStore : BaseEntityStore, IInvitationChannelEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationChannelEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public InvitationChannelEntityStore(EntitiesDbContext dbContext)
            : base (dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<InvitationChannelEntity> AddAsync(InvitationChannelEntity document)
        {
            await _dbContext.InvitationChannels.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var invitationChannelEntity =
                await _dbContext.InvitationChannels.FindAsync(id);
            if (invitationChannelEntity != null)
            {
                _dbContext.InvitationChannels.Remove(invitationChannelEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<InvitationChannelEntity> FetchByIdAsync(Guid id)
        {
            var invitationChannelEntity =
                await _dbContext.InvitationChannels.FindAsync(id);
            return invitationChannelEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<InvitationChannelEntity> GetDetail(Guid guid)
        {
            var invitationChannelEntity = await _dbContext.InvitationChannels.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return invitationChannelEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<InvitationChannelEntity>> ListAsync()
        {
            var invitationChannelEntityList =
                await _dbContext.InvitationChannels.ToListAsync();

            return invitationChannelEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<InvitationChannelEntity> UpdateByIdAsync(Guid id, InvitationChannelEntity document)
        {
            var invitationChannelEntityToUpdate =
                await _dbContext.InvitationChannels.FindAsync(id);
            invitationChannelEntityToUpdate.CreatedDate = DateTime.UtcNow;
            invitationChannelEntityToUpdate.Name = document.Name;
            invitationChannelEntityToUpdate.UpdatedDate = DateTime.UtcNow;
            invitationChannelEntityToUpdate.Id = document.Id;

            try
            {

                await Task.Run(() => _dbContext.InvitationChannels.Update(invitationChannelEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return invitationChannelEntityToUpdate;
        }
    }
}
