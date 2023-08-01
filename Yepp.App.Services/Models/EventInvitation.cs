using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class EventInvitation : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventInvitation"/> class.
        /// </summary>
        /// <param name="eventInvatitonEntity">The event invatiton entity.</param>
        public EventInvitation(EventInvitationEntity eventInvatitonEntity)
        {
            this.Id = eventInvatitonEntity.Id;
            this.CreatedDate = eventInvatitonEntity.CreatedDate;
            this.EventId = eventInvatitonEntity.EventId;
            this.UpdatedDate = DateTime.UtcNow;
            this.InvitationChannelId = eventInvatitonEntity.InvitationChannelId;
            this.Link = eventInvatitonEntity.Link;
            this.UserId = eventInvatitonEntity.UserId;
            this.TrackingNumber = eventInvatitonEntity.TrackingNumber;
        }

        /// <summary>Gets or sets the event identifier.</summary>
        /// <value>The event identifier.</value>
        [JsonProperty("event_id")]
        public Guid EventId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [JsonProperty("user_id")]
        public Guid UserId { get; set; }

        /// <summary>Gets or sets the invitation identifier.</summary>
        /// <value>The invitation identifier.</value>
        [JsonProperty("invitation_channel_id")]
        public Guid InvitationChannelId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>
        /// The link.
        /// </value>
        [JsonProperty("link")]
        public string Link { get; set; }

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
