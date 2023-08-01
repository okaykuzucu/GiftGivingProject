using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    /// <summary>
    /// The User Address Update
    /// </summary>
    /// <seealso cref="Yepp.App.Services.Models.AddressAddOptions" />
    public class AddressUpdateOptions 
    {
        /// <summary>Gets or sets the user identifier.</summary>
        /// <value>The user identifier.</value>
        [JsonProperty("user_id")]
        public Guid UserId { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the street.</summary>
        /// <value>The street.</value>
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        /// <summary>Gets or sets the number.</summary>
        /// <value>The number.</value>
        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        /// <summary>Gets or sets the zipcode.</summary>
        /// <value>The zipcode.</value>
        [JsonProperty("zipcode")]
        public int Zipcode { get; set; }

        /// <summary>Gets or sets the city identifier.</summary>
        /// <value>The city identifier.</value>
        [JsonProperty("city_id")]
        public Guid CityId { get; set; }

        /// <summary>Gets or sets the country identifier.</summary>
        /// <value>The country identifier.</value>
        [JsonProperty("country_id")]
        public Guid CountryId { get; set; }

        /// <summary>Gets or sets the address type identifier.</summary>
        /// <value>The address type identifier.</value>
        [JsonProperty("addressestypes_id")]
        public Guid AddressTypeId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }
    }
}
