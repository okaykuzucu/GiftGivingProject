using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.Services.Models;

namespace Yepp.App.Services
{
    /// <summary>
    /// The Game info service Interface
    /// </summary>
    public interface IGameInfoService
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="gameInfosAddOptions">The game infos add options.</param>
        /// <returns></returns>
        Task<GameInfo> AddAsync(GameInfoAddOptions gameInfosAddOptions);

        /// <summary>
        /// Lists the asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<GameInfo>> ListAsync();
    }
}
