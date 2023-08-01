using System;
using Yepp.App.Services.Enums;

namespace Yepp.App.WebCrawler.Attributes
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class CrawlerFieldAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the expression.
        /// </summary>
        /// <value>
        /// The expression.
        /// </value>
        public string Expression { get; set; }

        /// <summary>
        /// Gets or sets the type of the selector.
        /// </summary>
        /// <value>
        /// The type of the selector.
        /// </value>
        public CrowlerSelectorTypeEnum SelectorType { get; set; }
    }
}