using System.Text.Json.Serialization;

namespace Yepp.App.Services.Models
{
    public class SocialNetworks
    {
        /// <summary>
        /// Gets or sets the linked in.
        /// </summary>
        /// <value>
        /// The linked in.
        /// </value>
        [JsonPropertyName("linkedIn")]
        public string LinkedIn { get; set; }

        /// <summary>
        /// Gets or sets the facebook.
        /// </summary>
        /// <value>
        /// The facebook.
        /// </value>
        [JsonPropertyName("facebook")]
        public string Facebook { get; set; }

        /// <summary>
        /// Gets or sets the twitter.
        /// </summary>
        /// <value>
        /// The twitter.
        /// </value>
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// Gets or sets the instagram.
        /// </summary>
        /// <value>
        /// The instagram.
        /// </value>
        [JsonPropertyName("instagram")]
        public string Instagram { get; set; }
    }
}
