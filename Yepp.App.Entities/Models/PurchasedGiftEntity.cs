using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class PurchasedGiftEntity : BaseEntity
    {
        /// <summary>Gets or sets the gift identifier.</summary>
        /// <value>The gift identifier.</value>
        [Column("gift_id")]
        public Guid GiftId { get; set; }

        /// <summary>Gets or sets the purchase identifier.</summary>
        /// <value>The purchase identifier.</value>
        [Column("purchase_id")]
        public Guid PurchaseId { get; set; }

        /// <summary>Gets or sets the ship identifier.</summary>
        /// <value>The ship identifier.</value>
        [Column("ship_id")]
        public Guid ShipId { get; set; }

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
