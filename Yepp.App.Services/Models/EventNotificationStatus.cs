using Newtonsoft.Json;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class EventNotificationStatus : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventNotificationStatus"/> class.
        /// </summary>
        /// <param name="eventNotificationStatusEntity">The event notification status entity.</param>
        public EventNotificationStatus(EventNotificationStatusEntity eventNotificationStatusEntity)
        {
            this.Id = eventNotificationStatusEntity.Id;
            this.Name = eventNotificationStatusEntity.Name;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
