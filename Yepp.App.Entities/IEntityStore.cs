using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Yepp.App.Entities
{
    /// <summary>
    /// The entity store
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IEntityStore<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<TEntity> AddAsync(TEntity document);

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task DeleteByIdAsync(Guid id);

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<TEntity> FetchByIdAsync(Guid id);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> ListAsync();

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        Task<TEntity> UpdateByIdAsync(Guid id, TEntity document);
    }
}