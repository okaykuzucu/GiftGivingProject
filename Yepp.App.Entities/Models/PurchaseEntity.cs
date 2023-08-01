using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class PurchaseEntity : BaseEntity
    {
        /// <summary>Gets or sets the event identifier.</summary>
        /// <value>The event identifier.</value>
        [Column("event_id")]
        public Guid EventId { get; set; }

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
