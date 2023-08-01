using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    public class CityUpdateOptions
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The country identifier.
        /// </value>
        [JsonProperty("country_id")]
        public Guid CountryId { get; set; }
    }
}
