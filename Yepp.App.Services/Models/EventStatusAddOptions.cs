using Newtonsoft.Json;

namespace Yepp.App.Services.Models
{
    public class EventStatusAddOptions
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
