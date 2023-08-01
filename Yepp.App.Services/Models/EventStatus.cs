using Newtonsoft.Json;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class EventStatus : BaseEntity
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EventStatus"/> class.
        /// </summary>
        /// <param name="eventStatusEntity">The event status entity.</param>
        public EventStatus(EventStatusEntity eventStatusEntity)
        {
            this.Id = eventStatusEntity.Id;
            this.Name = eventStatusEntity.Name;
        }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
