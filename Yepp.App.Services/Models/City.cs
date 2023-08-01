using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class City : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="City"/> class.
        /// </summary>
        /// <param name="cityEntity">The city entity.</param>
        public City(CityEntity cityEntity)
        {
            this.Id = cityEntity.Id;
            this.Name = cityEntity.Name;
            this.CountryId = cityEntity.CountryId;
        }


        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("country_id")]
        public Guid CountryId { get; set; }
    }
}
