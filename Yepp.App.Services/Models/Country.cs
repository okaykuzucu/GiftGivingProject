using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class Country : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        /// <param name="countryEntity">The country entity.</param>
        public Country(CountryEntity countryEntity)
        {
            this.Id = countryEntity.Id;
            this.Name = countryEntity.Name;
            this.Iso = countryEntity.Iso;
        }

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
