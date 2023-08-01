using Newtonsoft.Json;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class Priority : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Priority"/> class.
        /// </summary>
        /// <param name="priorityEntities">The priority entities.</param>
        public Priority(PriorityEntity priorityEntities)
        {
            this.Id = priorityEntities.Id;
            this.Rate = priorityEntities.Rate;
        }

        /// <summary>Gets or sets the rate.</summary>
        /// <value>The rate.</value>
        [JsonProperty("rate")]
        public int Rate { get; set; }
    }
}
