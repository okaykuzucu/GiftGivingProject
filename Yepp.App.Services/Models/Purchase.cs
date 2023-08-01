using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class Purchase : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase"/> class.
        /// </summary>
        /// <param name="purchaseEntity">The purchase entity.</param>
        public Purchase(PurchaseEntity purchaseEntity)
        {
            this.Id = purchaseEntity.Id;
            this.CreatedDate = purchaseEntity.CreatedDate;
            this.EventId = purchaseEntity.EventId;
            this.UpdatedDate = purchaseEntity.UpdatedDate;
        }

        /// <summary>Gets or sets the event identifier.</summary>
        /// <value>The event identifier.</value>
        [JsonProperty("event_id")]
        public Guid EventId { get; set; }

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
