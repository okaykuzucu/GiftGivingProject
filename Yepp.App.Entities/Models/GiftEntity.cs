using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class GiftEntity : BaseEntity
    {
        /// <summary>Gets or sets the event identifier.</summary>
        /// <value>The event identifier.</value>
        [Column("event_id")]
        public Guid EventId { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the description.</summary>
        /// <value>The description.</value>
        [Column("description")]
        public string Description { get; set; }

        /// <summary>Gets or sets the price.</summary>
        /// <value>The price.</value>
        [Column("price")]
        public decimal Price { get; set; }

        /// <summary>Gets or sets the quantity.</summary>
        /// <value>The quantity.</value>
        [Column("quantity")]
        public int? Quantity { get; set; }

        /// <summary>Gets or sets the link.</summary>
        /// <value>The link.</value>
        [Column("link")]
        public string Link { get; set; }

        /// <summary>Gets or sets the image.</summary>
        /// <value>The image.</value>
        [Column("image")]
        public string Image { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the priority identifier.</summary>
        /// <value>The priority identifier.</value>
        [Column("priority_id")]
        public Guid PriorityId { get; set; }
    }

}
