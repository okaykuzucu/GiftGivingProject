using System.Text.Json.Serialization;

namespace Yepp.App.Services.Models
{
    public  class Communication
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Communication"/> is email.
        /// </summary>
        /// <value>
        ///   <c>true</c> if email; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("email")]
        public bool Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Communication"/> is SMS.
        /// </summary>
        /// <value>
        ///   <c>true</c> if SMS; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("sms")]
        public bool Sms { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Communication"/> is phone.
        /// </summary>
        /// <value>
        ///   <c>true</c> if phone; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("phone")]
        public bool Phone { get; set; }
    }
}
