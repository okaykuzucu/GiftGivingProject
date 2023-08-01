using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class ReturningUsersFromEventInvitation : BaseEntity
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturningUsersFromEventInvitation"/> class.
        /// </summary>
        /// <param name="returningUsersFromEventInvitationEntity">The returning users from event invitation entity.</param>
        public ReturningUsersFromEventInvitation(ReturningUsersFromEventInvitationEntity returningUsersFromEventInvitationEntity )
        {
            this.CreatedDate = DateTime.UtcNow;
            this.InvitationChannelId = returningUsersFromEventInvitationEntity.InvitationChannelId;
            this.Id = returningUsersFromEventInvitationEntity.Id;
            this.UpdatedDate = DateTime.UtcNow;
            this.UserId = returningUsersFromEventInvitationEntity.UserId;
            this.TrackingNumber = returningUsersFromEventInvitationEntity.TrackingNumber;
        }
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [JsonProperty("user_id")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the invitation channel identifier.
        /// </summary>
        /// <value>
        /// The invitation channel identifier.
        /// </value>
        [JsonProperty("invitation_channel_id")]
        public Guid InvitationChannelId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>
        /// The updated date.
        /// </value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the tracking number.
        /// </summary>
        /// <value>
        /// The tracking number.
        /// </value>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

    }
}
