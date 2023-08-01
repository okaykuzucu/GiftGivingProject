using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class EventNotificationEntity : BaseEntity
    {

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the event identifier.</summary>
        /// <value>The event identifier.</value>
        [Column("event_id")]
        public Guid EventId { get; set; }

        /// <summary>Gets or sets the gift identifier.</summary>
        /// <value>The gift identifier.</value>
        [Column("gift_id")]
        public Guid GiftId { get; set; }

        /// <summary>Gets or sets from user identifier.</summary>
        /// <value>From user identifier.</value>
        [Column("from_user_id")]
        public Guid FromUserId { get; set; }

        /// <summary>Converts to _user_id.</summary>
        /// <value>To user identifier.</value>
        [Column("to_user_id")]
        public Guid ToUserId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the balance.</summary>
        /// <value>The balance.</value>
        [Column("balance")]
        public decimal Balance { get; set; }

        /// <summary>Gets or sets the status identifier.</summary>
        /// <value>The status identifier.</value>
        [Column("status_id")]
        public Guid StatusId { get; set; }

    }
}
