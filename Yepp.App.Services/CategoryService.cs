using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryEntityStore _categoryEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryService"/> class.
        /// </summary>
        /// <param name="categoryEntityStore">The category entity store.</param>
        public CategoryService(ICategoryEntityStore categoryEntityStore)
        {
            _categoryEntityStore = categoryEntityStore;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="categoryAddOptions">The category add options.</param>
        /// <returns></returns>
        public async Task<Category> AddAsync(CategoryAddOptions categoryAddOptions)
        {
            var categoryEntity = new CategoryEntity
            {
                CreatedDate = DateTime.UtcNow,
                Name = categoryAddOptions.Name,
               
            };

            categoryEntity = await _categoryEntityStore.AddAsync(categoryEntity);

            var category = new Category(categoryEntity);

            return category;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        public async Task DeleteByIdAsync(Guid guid)
        {
            await _categoryEntityStore.DeleteByIdAsync(guid);
        }

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        public async Task<Category> GetDetail(Guid guid)
        {
            var categoryEntity = await _categoryEntityStore.GetDetail(guid);
            var category = new Category(categoryEntity);
            return category;
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> ListAsync()
        {
            var categoryEntityList = await _categoryEntityStore.ListAsync();
            var categoryList = categoryEntityList.Select(x => new Category(x));

            return categoryList;
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="categoryUpdateOptions">The category update options.</param>
        /// <returns></returns>
        public async Task<Category> UpdateByIdAsync(Guid guid, CategoryUpdateOptions categoryUpdateOptions)
        {
            var categoryEntity = await _categoryEntityStore.FetchByIdAsync(guid);
            categoryEntity.CreatedDate = categoryUpdateOptions.CreatedDate;
            categoryEntity.Name = categoryUpdateOptions.Name;
            categoryEntity.UpdatedDate = categoryUpdateOptions.UpdatedDate;

            categoryEntity = await _categoryEntityStore.UpdateByIdAsync(guid, categoryEntity);

            var category = new Category(categoryEntity);

            return category;

        }
    }
}
