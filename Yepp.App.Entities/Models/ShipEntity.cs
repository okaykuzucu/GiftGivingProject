using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class ShipEntity : BaseEntity
    {
        /// <summary>Gets or sets the address identifier.</summary>
        /// <value>The address identifier.</value>
        [Column("address_id")]
        public Guid AddressId { get; set; }

        /// <summary>Gets or sets the shipper identifier.</summary>
        /// <value>The shipper identifier.</value>
        [Column("shipper_id")]
        public Guid ShipperId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the tracking number.</summary>
        /// <value>The tracking number.</value>
        [Column("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
