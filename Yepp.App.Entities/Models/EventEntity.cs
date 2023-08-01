using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class EventEntity : BaseEntity
    {
        /// <summary>Gets or sets the user identifier.</summary>
        /// <value>The user identifier.</value>
        [Column("user_id")]
        public Guid UserId { get; set; }

        /// <summary>Gets or sets the categori identifier.</summary>
        /// <value>The categori identifier.</value>
        [Column("category_id")]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        [Column("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [Column("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        [Column("image")]
        public string Image { get; set; }

        /// <summary>Gets or sets the total balance.</summary>
        /// <value>The total balance.</value>
        [Column("total_balance")]
        public decimal TotalBalance { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the end date.</summary>
        /// <value>The end date.</value>
        [Column("end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>Gets or sets the status identifier.</summary>
        /// <value>The status identifier.</value>
        [Column("status_id")]
        public Guid StatusId { get; set; }

        /// <summary>Gets or sets the status identifier.</summary>
        /// <value>The payment identifier.</value>
        [Column("payment")]
        public bool? payment { get; set; }

        /// <summary>Gets or sets the status identifier.</summary>
        /// <value>The payuPaymentReference identifier.</value>
        [Column("payuPaymentReference")]
        public string? payuPaymentReference { get; set; }
    }
}
