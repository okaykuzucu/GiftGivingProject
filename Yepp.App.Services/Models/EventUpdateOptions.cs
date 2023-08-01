using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Services.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class EventUpdateOptions
    {
        /// <summary>Gets or sets the user identifier.</summary>
        /// <value>The user identifier.</value>
        [JsonProperty("user_id")]
        public Guid UserId { get; set; }

        /// <summary>Gets or sets the categori identifier.</summary>
        /// <value>The categori identifier.</value>
        [JsonProperty("category_id")]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>Gets or sets the image.</summary>
        /// <value>The image.</value>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>Gets or sets the total balance.</summary>
        /// <value>The total balance.</value>
        [JsonProperty("total_balance")]
        public decimal TotalBalance { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the end date.</summary>
        /// <value>The end date.</value>
        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>Gets or sets the status identifier.</summary>
        /// <value>The status identifier.</value>
        [JsonProperty("status_id")]
        public Guid StatusId { get; set; }

        /// <summary>Gets or sets the status identifier.</summary>
        /// <value>The payment identifier.</value>
        [JsonProperty("payment")]
        public bool? payment { get; set; }

        /// <summary>Gets or sets the status identifier.</summary>
        /// <value>The payuPaymentReference identifier.</value>
        [Column("payuPaymentReference")]
        public string? payuPaymentReference { get; set; }
    }
}
