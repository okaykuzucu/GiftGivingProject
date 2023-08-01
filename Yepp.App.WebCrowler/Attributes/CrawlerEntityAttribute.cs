using System;

namespace Yepp.App.WebCrawler.Attributes
{
    /// <summary>
    ///Crowler Entity Attrinute
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class CrawlerEntityAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the x path.
        /// </summary>
        /// <value>
        /// The x path.
        /// </value>
        public string XPath { get; set; }
    }
}