using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class PurchasedGift
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchasedGift"/> class.
        /// </summary>
        /// <param name="purchasedGiftEntity">The purchased gift entity.</param>
        public PurchasedGift(PurchasedGiftEntity purchasedGiftEntity)
        {
            this.CreatedDate = purchasedGiftEntity.CreatedDate;
            this.GiftId = purchasedGiftEntity.GiftId;
            this.PurchaseId= purchasedGiftEntity.PurchaseId;
            this.ShipId = purchasedGiftEntity.ShipId;
            this.UpdatedDate = purchasedGiftEntity.UpdatedDate;
        }

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
