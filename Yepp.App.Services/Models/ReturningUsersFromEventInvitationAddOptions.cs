using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Services.Models
{
    public class ReturningUsersFromEventInvitationAddOptions
    {
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
