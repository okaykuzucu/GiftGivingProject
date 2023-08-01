using System.Text.Json.Serialization;

namespace Yepp.App.Services.Models
{
    public  class UpdatesFromKeenthemes
    {
        /// <summary>
        /// Gets or sets a value indicating whether [news about keenthemes products and feature updates].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [news about keenthemes products and feature updates]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("newsAboutKeenthemesProductsAndFeatureUpdates")]
        public bool NewsAboutKeenthemesProductsAndFeatureUpdates { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [tips on getting more out of keen].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [tips on getting more out of keen]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("tipsOnGettingMoreOutOfKeen")]
        public bool TipsOnGettingMoreOutOfKeen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [things you missed sinde you last logged into keen].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [things you missed sinde you last logged into keen]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("thingsYouMissedSindeYouLastLoggedIntoKeen")]
        public bool ThingsYouMissedSindeYouLastLoggedIntoKeen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [news about metronic on partner products and other services].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [news about metronic on partner products and other services]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("newsAboutMetronicOnPartnerProductsAndOtherServices")]
        public bool NewsAboutMetronicOnPartnerProductsAndOtherServices { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [tips on metronic business products].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [tips on metronic business products]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("tipsOnMetronicBusinessProducts")]
        public bool TipsOnMetronicBusinessProducts { get; set; }
    }
}
