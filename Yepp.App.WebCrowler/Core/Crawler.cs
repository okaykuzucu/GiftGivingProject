using System.Collections.Generic;
using System.Threading.Tasks;
using Yepp.App.WebCrawler.Downloader;
using Yepp.App.WebCrawler.Processor;
using Yepp.App.WebCrawler.Request;
using Yepp.App.WebCrawler.Scheduler;

namespace Yepp.App.WebCrawler.Core
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="Yepp.App.WebCrawler.Core.ICrawler" />
    public class Crawler<TEntity> : ICrawler<TEntity> where TEntity : class
    {
        /// <summary>
        /// Gets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        public ICrawlerRequest Request { get; private set; }

        /// <summary>
        /// Gets the downloader.
        /// </summary>
        /// <value>
        /// The downloader.
        /// </value>
        public ICrawlerDownloader Downloader { get; private set; }

        /// <summary>
        /// Gets the processor.
        /// </summary>
        /// <value>
        /// The processor.
        /// </value>
        public ICrawlerProcessor<TEntity> Processor { get; private set; }

        /// <summary>
        /// Gets the scheduler.
        /// </summary>
        /// <value>
        /// The scheduler.
        /// </value>
        public ICrawlerScheduler Scheduler { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crawler{TEntity}"/> class.
        /// </summary>
        public Crawler()
        {
        }

        /// <summary>
        /// Adds the request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Crawler<TEntity> AddRequest(ICrawlerRequest request)
        {
            Request = request;
            return this;
        }

        /// <summary>
        /// Adds the downloader.
        /// </summary>
        /// <param name="downloader">The downloader.</param>
        /// <returns></returns>
        public Crawler<TEntity> AddDownloader(ICrawlerDownloader downloader)
        {
            Downloader = downloader;
            return this;
        }

        /// <summary>
        /// Adds the processor.
        /// </summary>
        /// <param name="processor">The processor.</param>
        /// <returns></returns>
        public Crawler<TEntity> AddProcessor(ICrawlerProcessor<TEntity> processor)
        {
            Processor = processor;
            return this;
        }

        /// <summary>
        /// Adds the scheduler.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public Crawler<TEntity> AddScheduler(ICrawlerScheduler scheduler)
        {
            Scheduler = scheduler;
            return this;
        }

        /// <summary>
        /// Crawles this instance.
        /// </summary>
        public async Task<IEnumerable<TEntity>> Sahibinden(string selectedMarketPlaceId)
        {
            IEnumerable<TEntity> crawlerList = new List<TEntity>();

            var document = await Downloader.Download(Request.Url);

            crawlerList = await Processor.Sahibinden(document);

            return
                crawlerList;
        }
    }
}