using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    public class PriorityEntityStore : BaseEntityStore, IPriorityEntityStore
    {
        /// <summary>Initializes a new instance of the <see cref="RoleEntityStore" /> class.</summary>
        /// <param name="dbContext">The database context.</param>
        public PriorityEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<PriorityEntity> AddAsync(PriorityEntity document)
        {
            await _dbContext.Priorities.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var prioritiesEntity =
            await _dbContext.Priorities.FindAsync(id);

            if (prioritiesEntity != null)
            {
                _dbContext.Priorities.Remove(prioritiesEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<PriorityEntity> FetchByIdAsync(Guid id)
        {
            var prioritiesEntity =
             await _dbContext.Priorities.FindAsync(id);

            return prioritiesEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<PriorityEntity> GetDetail(Guid guid)
        {
            return await _dbContext.Priorities.Where(x => x.Id == guid).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PriorityEntity>> ListAsync()
        {
            var priorityEntityList =
           await _dbContext.Priorities.ToListAsync();

            return priorityEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<PriorityEntity> UpdateByIdAsync(Guid id, PriorityEntity document)
        {
            var prioritiesEntityToUpdate =
            await _dbContext.Priorities.FindAsync(id);
            prioritiesEntityToUpdate.Id = document.Id;
            prioritiesEntityToUpdate.Rate = document.Rate;
            await _dbContext.SaveChangesAsync();

            try
            {

                await Task.Run(() => _dbContext.Priorities.Update(prioritiesEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return prioritiesEntityToUpdate;
        }
    }
}
