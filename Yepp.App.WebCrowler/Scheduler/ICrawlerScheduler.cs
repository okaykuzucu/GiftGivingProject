using System.Threading.Tasks;

namespace Yepp.App.WebCrawler.Scheduler
{
    /// <summary>
    ///
    /// </summary>
    public interface ICrawlerScheduler
    {
        /// <summary>
        /// Gets or sets the retry time.
        /// </summary>
        /// <value>
        /// The retry time.
        /// </value>
        long RetryTime { get; set; }

        /// <summary>
        /// Schedules this instance.
        /// </summary>
        /// <returns></returns>
        Task Schedule();
    }
}