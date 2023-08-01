using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    public class PurchasedGiftAddOptions
    {
        /// <summary>Gets or sets the gift identifier.</summary>
        /// <value>The gift identifier.</value>
        [JsonProperty("gift_id")]
        public Guid GiftId { get; set; }

        /// <summary>Gets or sets the purchase identifier.</summary>
        /// <value>The purchase identifier.</value>
        [JsonProperty("purchase_id")]
        public Guid PurchaseId { get; set; }

        /// <summary>Gets or sets the ship identifier.</summary>
        /// <value>The ship identifier.</value>
        [JsonProperty("ship_id")]
        public Guid ShipId { get; set; }

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

