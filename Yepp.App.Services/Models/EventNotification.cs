using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class EventNotification : BaseEntity
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EventNotification"/> class.
        /// </summary>
        /// <param name="eventNotificationEntity">The event notification entity.</param>
        public EventNotification(EventNotificationEntity eventNotificationEntity)
        {
            this.Id = eventNotificationEntity.Id;
            this.CreatedDate = eventNotificationEntity.CreatedDate;
            this.FromUserId = eventNotificationEntity.FromUserId;
            this.GiftId = eventNotificationEntity.GiftId;
            this.Name = eventNotificationEntity.Name;
            this.ToUserId = eventNotificationEntity.ToUserId;
            this.UpdatedDate = eventNotificationEntity.UpdatedDate;
        }
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the event identifier.</summary>
        /// <value>The event identifier.</value>
        [JsonProperty("event_id")]
        public string EventId { get; set; }

        /// <summary>Gets or sets the gift identifier.</summary>
        /// <value>The gift identifier.</value>
        [JsonProperty("gift_id")]
        public Guid GiftId { get; set; }

        /// <summary>Gets or sets from user identifier.</summary>
        /// <value>From user identifier.</value>
        [JsonProperty("from_user_id")]
        public Guid FromUserId { get; set; }

        /// <summary>Converts to _user_id.</summary>
        /// <value>To user identifier.</value>
        [JsonProperty("to_user_id")]
        public Guid ToUserId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [JsonProperty("crated_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the balance.</summary>
        /// <value>The balance.</value>
        [JsonProperty("balance")]
        public int Balance { get; set; }

        /// <summary>Gets or sets the status identifier.</summary>
        /// <value>The status identifier.</value>
        [JsonProperty("status_id")]
        public string StatusId { get; set; }
    }
}
