using Newtonsoft.Json;

namespace Yepp.App.Services.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AddressTypeUpdateOptions
    {
        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
