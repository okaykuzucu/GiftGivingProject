using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class GiftPaymentTransaction : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GiftPaymentTransaction"/> class.
        /// </summary>
        /// <param name="giftPaymentTransactionEntity">The gift payment transaction entity.</param>
        public GiftPaymentTransaction(GiftPaymentTransactionEntity giftPaymentTransactionEntity)
        {
            this.Id = giftPaymentTransactionEntity.Id;
            this.ActualPrice = giftPaymentTransactionEntity.ActualPrice;
            this.CreatedDate = DateTime.UtcNow;
            this.GiftId = giftPaymentTransactionEntity.GiftId;
            this.UpdatedDate = DateTime.UtcNow;
            this.UserId = giftPaymentTransactionEntity.UserId;      
        }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [JsonProperty("user_id")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the gift identifier.
        /// </summary>
        /// <value>
        /// The gift identifier.
        /// </value>
        [JsonProperty("gift_id")]
        public Guid GiftId { get; set; }

        /// <summary>
        /// Gets or sets the actual price.
        /// </summary>
        /// <value>
        /// The actual price.
        /// </value>
        [JsonProperty("actual_price")]
        public Guid ActualPrice { get; set; }

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
