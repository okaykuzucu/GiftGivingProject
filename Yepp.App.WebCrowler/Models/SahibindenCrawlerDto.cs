using Yepp.App.Services.Enums;
using Yepp.App.WebCrawler.Attributes;

namespace Yepp.App.WebCrawler.Models
{
    [CrawlerEntity(XPath = "//*[@id='classifiedDetail']/div/div[3]/div[2]")]
    public class SahibindenCrawlerDto
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [CrawlerField(Expression = "//*[@id='classifiedDetail']/div/div[3]/div[2]/h3/text()", SelectorType = CrowlerSelectorTypeEnum.XPath)]
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>
        /// The image path.
        /// </value>
        [CrawlerField(Expression = "/html/body/div[4]/div[4]/div/div[3]/div[1]/div[1]/label[2]/img/@src", SelectorType = CrowlerSelectorTypeEnum.XPath)]
        public string ImagePath { get; set; }
    }
}