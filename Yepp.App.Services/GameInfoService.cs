using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yepp.App.Entities.Models;
using Yepp.App.Entities.Stores;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    /// <summary>
    /// Game Info Services
    /// </summary>
    /// <seealso cref="Yepp.App.Services.IGameInfoService" />
    public class GameInfoService : IGameInfoService
    {
        /// <summary>
        /// The game information entity store
        /// </summary>
        private readonly IGameInfoEntityStore _gameInfoEntityStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameInfoService"/> class.
        /// </summary>
        /// <param name="gameInfoEntityStore">The game information entity store.</param>
        public GameInfoService(IGameInfoEntityStore gameInfoEntityStore)
        {
            _gameInfoEntityStore = gameInfoEntityStore;
        }


        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="gameInfosAddOptions">The game infos add options.</param>
        /// <returns></returns>
        public async Task<GameInfo> AddAsync(GameInfoAddOptions gameInfosAddOptions)
        {
            var gameInfoEntity = new GameInfoEntity
            {
                Email = gameInfosAddOptions.Email,
                SurName = gameInfosAddOptions.SurName,
                GameScore = gameInfosAddOptions.GameScore,
                Name = gameInfosAddOptions.Name,
                Language=gameInfosAddOptions.Language
                
            };

            gameInfoEntity = await _gameInfoEntityStore.AddAsync(gameInfoEntity);

            var gameInfo = new GameInfo(gameInfoEntity);

            return gameInfo;
            
        }

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<GameInfo>> ListAsync()
        {
            var gameInfoEntityList = await _gameInfoEntityStore.ListAsync();
            var gameInfoList = gameInfoEntityList.Select(x => new GameInfo(x));

            return gameInfoList;
        }
    }
}
