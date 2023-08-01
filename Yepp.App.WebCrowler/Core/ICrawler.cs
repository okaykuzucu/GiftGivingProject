using System.Collections.Generic;
using System.Threading.Tasks;

namespace Yepp.App.WebCrawler.Core
{
    /// <summary>
    /// The Crawler
    /// </summary>
    public interface ICrawler<TEntity> where TEntity : class
    {
        /// <summary>
        /// Sahibinden the specified selected market place identifier.
        /// </summary>
        /// <param name="selectedMarketPlaceId">The selected market place identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> Sahibinden(string selectedMarketPlaceId);
    }
}