using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;

namespace Yepp.App.Entities.Stores
{
    /// <summary>
    /// The Game Info Entity Service
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntityStore" />
    /// <seealso cref="Yepp.App.Entities.Stores.IGameInfoEntityStore" />
    public class GameInfoEntityStore : BaseEntityStore, IGameInfoEntityStore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameInfoEntityStore"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public GameInfoEntityStore(EntitiesDbContext dbContext)
            : base(dbContext)
        {
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        public async Task<GameInfoEntity> AddAsync(GameInfoEntity document)
        {
            await _dbContext.GameInfos.AddAsync(document);
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var _ex = ex.ToString();
                throw;
            }

            return document;
        }

        /// <summary>
        /// Deletes the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetches the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<GameInfoEntity> FetchByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GameInfoEntity>> ListAsync()
        {
            return await _dbContext.GameInfos.ToListAsync();
        }

        /// <summary>
        /// Updates the by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="document">The document.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<GameInfoEntity> UpdateByIdAsync(Guid id, GameInfoEntity document)
        {
            throw new NotImplementedException();
        }
    }
}
