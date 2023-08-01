using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.WebCrawler.Request
{
    /// <summary>
    /// Request Crawler
    /// </summary>
    /// <seealso cref="Yepp.App.WebCrawler.Request.ICrawlerRequest" />
    public class CrawlerRequest : ICrawlerRequest
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the regex.
        /// </summary>
        /// <value>
        /// The regex.
        /// </value>
        public string Regex { get; set; }

        /// <summary>
        /// Gets or sets the time out.
        /// </summary>
        /// <value>
        /// The time out.
        /// </value>
        public long TimeOut { get; set; }
    }
}