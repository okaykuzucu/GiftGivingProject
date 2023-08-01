using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Yepp.App.WebCrawler.Downloader.Enums;

namespace Yepp.App.WebCrawler.Downloader
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Yepp.App.WebCrawler.Downloader.ICrawlerDownloader" />
    public class CrawlerDownloader : ICrawlerDownloader
    {
        /// <summary>
        /// Gets or sets the type of the downloder.
        /// </summary>
        /// <value>
        /// The type of the downloder.
        /// </value>
        public CrawlerDownloaderType DownloderType { get; set; }

        /// <summary>
        /// Gets or sets the download path.
        /// </summary>
        /// <value>
        /// The download path.
        /// </value>
        public string DownloadPath { get; set; }

        private string _localFilePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlerDownloader"/> class.
        /// </summary>
        public CrawlerDownloader()
        {
        }

        /// <summary>
        /// Downloads the specified crawl URL.
        /// </summary>
        /// <param name="crawlUrl">The crawl URL.</param>
        /// <returns></returns>
        public async Task<HtmlDocument> Download(string crawlUrl)
        {
            // if exist dont download again
            PrepareFilePath(crawlUrl);

            var existing = GetExistingFile(_localFilePath);
            if (existing != null)
                return existing;

            return await DownloadInternal(crawlUrl);
        }

        /// <summary>
        /// Downloads the internal.
        /// </summary>
        /// <param name="crawlUrl">The crawl URL.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Can not load html file from given source.</exception>
        private async Task<HtmlDocument> DownloadInternal(string crawlUrl)
        {
            HtmlDocument htmlDocument;
            string htmlCode;
            switch (DownloderType)
            {
                case CrawlerDownloaderType.FromFile:
                    using (WebClient client = new WebClient())
                    {
                        await client.DownloadFileTaskAsync(crawlUrl, _localFilePath);
                    }
                    return GetExistingFile(_localFilePath);

                case CrawlerDownloaderType.FromMemory:
                    htmlDocument = new HtmlDocument();
                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            htmlCode = await client.DownloadStringTaskAsync(crawlUrl);
                        }
                        catch (Exception ex)
                        {
                            var _ex = ex.ToString();
                            throw;
                        }
                        htmlDocument.LoadHtml(htmlCode);
                    }
                    //TODO : - Okan Memory e alındı
                    return htmlDocument;

                case CrawlerDownloaderType.FromWeb:
                    HtmlWeb web = new HtmlWeb();
                    return await web.LoadFromWebAsync(crawlUrl);
            }

            throw new InvalidOperationException("Can not load html file from given source.");
        }

        /// <summary>
        /// Prepares the file path.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        private void PrepareFilePath(string fileName)
        {
            var parts = fileName.Split('/');
            parts = parts.Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
            var htmlpage = string.Empty;
            if (parts.Length > 0)
            {
                htmlpage = parts[parts.Length - 1];
            }

            if (!htmlpage.Contains(".html"))
            {
                htmlpage = htmlpage + ".html";
            }
            htmlpage = htmlpage.Replace("=", "").Replace("?", "");

            _localFilePath = $"{DownloadPath}{htmlpage}";
        }

        /// <summary>
        /// Gets the existing file.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <returns></returns>
        private HtmlDocument GetExistingFile(string fullPath)
        {
            try
            {
                var htmlDocument = new HtmlDocument();
                htmlDocument.Load(fullPath);
                return htmlDocument;
            }
            catch (Exception exception)
            {
            }
            return null;
        }
    }
}