using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    public class GiftPaymentTransactionEntity : BaseEntity
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [Column("user_id")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the gift identifier.
        /// </summary>
        /// <value>
        /// The gift identifier.
        /// </value>
        [Column("gift_id")]
        public Guid GiftId { get; set; }

        /// <summary>
        /// Gets or sets the actual price.
        /// </summary>
        /// <value>
        /// The actual price.
        /// </value>
        [Column("actual_price")]
        public Guid ActualPrice { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }
    }
}
