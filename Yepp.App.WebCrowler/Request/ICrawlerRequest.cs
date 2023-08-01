using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.WebCrawler.Request
{
    /// <summary>
    /// The crawler request interface
    /// </summary>
    public interface ICrawlerRequest
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        string Url { get; set; }

        /// <summary>
        /// Gets or sets the regex.
        /// </summary>
        /// <value>
        /// The regex.
        /// </value>
        string Regex { get; set; }

        /// <summary>
        /// Gets or sets the time out.
        /// </summary>
        /// <value>
        /// The time out.
        /// </value>
        long TimeOut { get; set; }
    }
}