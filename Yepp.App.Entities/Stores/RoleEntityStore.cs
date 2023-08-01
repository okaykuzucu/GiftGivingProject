using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{

    /// <summary>
    ///  the role entity store
    /// </summary>
    public class RoleEntityStore : BaseEntityStore, IRoleEntityStore
    {

        /// <summary>Initializes a new instance of the <see cref="RoleEntityStore" /> class.</summary>
        /// <param name="dbContext">The database context.</param>
        public RoleEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }

        /// <summary>Adds the asynchronous.</summary>
        /// <param name="document">The document.</param>
        /// <returns>
        ///   Role Entity
        /// </returns>
        public async Task<RoleEntity> AddAsync(RoleEntity document)
        {
            await _dbContext.Roles.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>Deletes the by identifier asynchronous.</summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var rolesEntity =
              await _dbContext.Roles.FindAsync(id);

            if (rolesEntity != null)
            {
                _dbContext.Roles.Remove(rolesEntity);

                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>Fetches the by identifier asynchronous.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   Role Entity
        /// </returns>
        public async Task<RoleEntity> FetchByIdAsync(Guid id)
        {
            var rolesEntity =
               await _dbContext.Roles.FindAsync(id);

            return rolesEntity;
        }

        /// <summary>Gets the detail.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>
        ///   Role
        /// </returns>
        public async Task<RoleEntity> GetDetail(Guid guid)
        {
            return await _dbContext.Roles.Where(x => x.Id == guid).FirstOrDefaultAsync();            
        }

        /// <summary>Lists the asynchronous.</summary>
        /// <returns>
        ///   Role Entities
        /// </returns>
        public async Task<IEnumerable<RoleEntity>> ListAsync()
        {
            var rolesEntityList =
            await _dbContext.Roles.ToListAsync();

            return rolesEntityList;
        }

        /// <summary>Updates the by identifier asynchronous.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns>
        ///   Role Entity
        /// </returns>
        public async Task<RoleEntity> UpdateByIdAsync(Guid id, RoleEntity document)
        {
            var rolesEntityToUpdate =
            await _dbContext.Roles.FindAsync(id);
            rolesEntityToUpdate.Name = document.Name;
            await _dbContext.SaveChangesAsync();

            return rolesEntityToUpdate;
        }       
    }
}
