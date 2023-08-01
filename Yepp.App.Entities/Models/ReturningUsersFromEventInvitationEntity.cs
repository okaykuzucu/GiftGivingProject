using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntity" />
    public class ReturningUsersFromEventInvitationEntity : BaseEntity
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
        /// Gets or sets the event invitation identifier.
        /// </summary>
        /// <value>
        /// The event invitation identifier.
        /// </value>
        [Column("invitation_channel_id")]
        public Guid InvitationChannelId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>
        /// The updated date.
        /// </value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

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
