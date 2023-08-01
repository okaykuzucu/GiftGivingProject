using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    public interface ICategoryService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="categoryAddOptions">The category add options.</param>
        /// <returns></returns>
        Task<Category> AddAsync(CategoryAddOptions categoryAddOptions);

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="categoryUpdateOptions">The category update options.</param>
        /// <returns></returns>
        Task<Category> UpdateByIdAsync(Guid guid, CategoryUpdateOptions categoryUpdateOptions);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid guid);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Category>> ListAsync();

        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Task<Category> GetDetail(Guid guid);

    }
}
