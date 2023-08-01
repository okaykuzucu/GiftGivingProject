using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public class AcceptedMarketplacesEntityStore : BaseEntityStore, IAcceptedMarketplacesEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptedMarketplacesEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public AcceptedMarketplacesEntityStore(EntitiesDbContext dbContext)
         : base(dbContext)
        {

        }
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<AcceptedMarketplacesEntity> AddAsync(AcceptedMarketplacesEntity document)
        {
            await _dbContext.AcceptedMarketplaces.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }
        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {

            var acceptedMarketplacesEntity =
                await _dbContext.AcceptedMarketplaces.FindAsync(id);

            if (acceptedMarketplacesEntity != null)
            {
                _dbContext.AcceptedMarketplaces.Remove(acceptedMarketplacesEntity);

                await _dbContext.SaveChangesAsync();

            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<AcceptedMarketplacesEntity> FetchByIdAsync(Guid id)
        {
            var acceptedMarketplacesEntity =
            await _dbContext.AcceptedMarketplaces.FindAsync(id);

            return acceptedMarketplacesEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<AcceptedMarketplacesEntity> GetDetail(Guid guid)
        {
            var acceptedMarketplacesEntity = await _dbContext.AcceptedMarketplaces.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return acceptedMarketplacesEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AcceptedMarketplacesEntity>> ListAsync()
        {
            var acceptedMarketplacesEntityList =
            await _dbContext.AcceptedMarketplaces.ToListAsync();

            return acceptedMarketplacesEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<AcceptedMarketplacesEntity> UpdateByIdAsync(Guid id, AcceptedMarketplacesEntity document)
        {
            var acceptedMarketplacesEntityToUpdate =
                await _dbContext.AcceptedMarketplaces.FindAsync(id);
            acceptedMarketplacesEntityToUpdate.CreatedDate = DateTime.UtcNow;
            acceptedMarketplacesEntityToUpdate.Name = acceptedMarketplacesEntityToUpdate.Name;
            acceptedMarketplacesEntityToUpdate.Id = acceptedMarketplacesEntityToUpdate.Id;
            acceptedMarketplacesEntityToUpdate.UpdatedDate = DateTime.UtcNow;
            acceptedMarketplacesEntityToUpdate.WebSite = acceptedMarketplacesEntityToUpdate.WebSite;
            await _dbContext.SaveChangesAsync();

            try
            {
                await Task.Run(() => _dbContext.AcceptedMarketplaces.Update(acceptedMarketplacesEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }
            return acceptedMarketplacesEntityToUpdate;
        }
    }
}
