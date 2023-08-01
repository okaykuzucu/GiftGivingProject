using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class AcceptedMarketplaces : BaseEntity
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptedMarketplaces"/> class.
        /// </summary>
        /// <param name="acceptedMarketplacesEntity">The accepted marketplaces entity.</param>
        public AcceptedMarketplaces(AcceptedMarketplacesEntity acceptedMarketplacesEntity)
        {
            this.CreatedDate = DateTime.UtcNow;
            this.Id = acceptedMarketplacesEntity.Id;
            this.Name = acceptedMarketplacesEntity.Name;
            this.WebSite = acceptedMarketplacesEntity.WebSite;
            this.UpdatedDate = DateTime.UtcNow;

        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the web site.
        /// </summary>
        /// <value>
        /// The web site.
        /// </value>
        [JsonProperty("web_site")]
        public string WebSite { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>
        /// The updated date.
        /// </value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

    }
}
