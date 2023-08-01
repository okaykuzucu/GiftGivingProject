using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class EventInvitationEntity : BaseEntity
    {
  
        /// <summary>Gets or sets the event identifier.</summary>
        /// <value>The event identifier.</value>
        [Column("event_id")]
        public Guid EventId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [Column("user_id")]
        public Guid UserId { get; set; }

        /// <summary>Gets or sets the invitation identifier.</summary>
        /// <value>The invitation identifier.</value>
        [Column("invitation_channel_id")]
        public Guid InvitationChannelId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>
        /// The link.
        /// </value>
        [Column("link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the tracking number.
        /// </summary>
        /// <value>
        /// The tracking number.
        /// </value>
        [Column("tracking_number")]
        public string TrackingNumber { get; set; }

    }
}
