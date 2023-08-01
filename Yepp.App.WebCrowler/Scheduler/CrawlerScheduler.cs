using System;
using System.Threading.Tasks;

namespace Yepp.App.WebCrawler.Scheduler
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Yepp.App.WebCrawler.Scheduler.ICrawlerScheduler" />
    internal class CrawlerScheduler : ICrawlerScheduler
    {
        /// <summary>
        /// Gets or sets the retry time.
        /// </summary>
        /// <value>
        /// The retry time.
        /// </value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        public long RetryTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Schedules this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task Schedule()
        {
            // TODO : Implement Quartz or Hangfire
            throw new NotImplementedException();
        }
    }
}