using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    public class CityAddOptions
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_id")]
        public Guid CountryId { get; set; }
    }
}
