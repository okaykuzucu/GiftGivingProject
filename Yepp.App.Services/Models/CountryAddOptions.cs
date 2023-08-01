using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    public class CountryAddOptions
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the iso.</summary>
        /// <value>The iso.</value>
        [JsonProperty("iso")]
        public string Iso { get; set; }
    }
}
