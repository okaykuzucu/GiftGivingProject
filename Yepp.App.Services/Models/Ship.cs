using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class Ship : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ship"/> class.
        /// </summary>
        /// <param name="shipEntity">The ship entity.</param>
        public Ship(ShipEntity shipEntity)
        {
            this.Id = shipEntity.Id;
            this.AddressId = shipEntity.AddressId;
            this.CreatedDate = DateTime.UtcNow;
            this.ShipperId = shipEntity.ShipperId;
            this.TrackingNumber = shipEntity.TrackingNumber;
            this.UpdatedDate = DateTime.UtcNow;
        }

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
