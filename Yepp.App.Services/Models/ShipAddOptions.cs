using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    public class ShipAddOptions
    {
        /// <summary>Gets or sets the address identifier.</summary>
        /// <value>The address identifier.</value>
        [JsonProperty("address_id")]
        public Guid AddressId { get; set; }

        /// <summary>Gets or sets the shipper identifier.</summary>
        /// <value>The shipper identifier.</value>
        [JsonProperty("shipper_id")]
        public Guid ShipperId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the tracking number.</summary>
        /// <value>The tracking number.</value>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
