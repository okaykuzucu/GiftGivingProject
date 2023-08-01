using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// User entity store
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.IUserEntityStore" />
    public class CategoryEntityStore : BaseEntityStore, ICategoryEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public CategoryEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<CategoryEntity> AddAsync(CategoryEntity document)
        {
            await _dbContext.Categories.AddAsync(document);
            await _dbContext.SaveChangesAsync();

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteByIdAsync(Guid id)
        {
            var categoryEntity =
                await _dbContext.Categories.FindAsync(id);

            if(categoryEntity != null)
            {
                _dbContext.Categories.Remove(categoryEntity);

                await _dbContext.SaveChangesAsync();
            }
            
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<CategoryEntity> FetchByIdAsync(Guid id)
        {
            var categoryEntity =
                await _dbContext.Categories.FindAsync(id);

            return categoryEntity;
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<CategoryEntity> GetDetail(Guid guid)
        {
            var categoryEntity = await _dbContext.Categories.Where(x => x.Id == guid).FirstOrDefaultAsync();

            return categoryEntity;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CategoryEntity>> ListAsync()
        {
            var categoryEntityList =
            await _dbContext.Categories.ToListAsync();

            return categoryEntityList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<CategoryEntity> UpdateByIdAsync(Guid id, CategoryEntity document)
        {
            var categoryEntityToUpdate =
            await _dbContext.Categories.FindAsync(id);
            categoryEntityToUpdate.CreatedDate = DateTime.UtcNow;
            categoryEntityToUpdate.Id = document.Id;
            categoryEntityToUpdate.Name = document.Name;
            categoryEntityToUpdate.CreatedDate = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync();

            try
            {

                await Task.Run(() => _dbContext.Categories.Update(categoryEntityToUpdate));

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var aaa = ex.ToString();
                throw;
            }

            return categoryEntityToUpdate;
            
        }
    }
}