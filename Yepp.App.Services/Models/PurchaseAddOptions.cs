using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    public class PurchaseAddOptions
    {
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
