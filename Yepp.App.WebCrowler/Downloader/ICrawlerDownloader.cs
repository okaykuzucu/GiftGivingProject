using HtmlAgilityPack;
using System.Threading.Tasks;
using Yepp.App.WebCrawler.Downloader.Enums;

namespace Yepp.App.WebCrawler.Downloader
{
    /// <summary>
    ///
    /// </summary>
    public interface ICrawlerDownloader
    {
        /// <summary>
        /// Gets or sets the type of the downloder.
        /// </summary>
        /// <value>
        /// The type of the downloder.
        /// </value>
        CrawlerDownloaderType DownloderType { get; set; }

        /// <summary>
        /// Gets or sets the download path.
        /// </summary>
        /// <value>
        /// The download path.
        /// </value>
        string DownloadPath { get; set; }

        /// <summary>
        /// Downloads the specified crawl URL.
        /// </summary>
        /// <param name="crawlUrl">The crawl URL.</param>
        /// <returns></returns>
        Task<HtmlDocument> Download(string crawlUrl);
    }
}