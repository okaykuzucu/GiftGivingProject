using System.Text.Json.Serialization;

namespace Yepp.App.Services.Models
{
    public  class EmailSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether [email notification].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [email notification]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("emailNotification")]
        public bool EmailNotification { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send copmy to personal email].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [send copmy to personal email]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("sendCopyToPersonalEmail")]
        public bool SendCopmyToPersonalEmail { get; set; }

        /// <summary>
        /// Gets or sets the activity relates email.
        /// </summary>
        /// <value>
        /// The activity relates email.
        /// </value>
        [JsonPropertyName("activityRelatesEmail")]
        public ActivityRelatesEmail ActivityRelatesEmail { get; set; }

        /// <summary>
        /// Gets or sets the updates from keenthemes.
        /// </summary>
        /// <value>
        /// The updates from keenthemes.
        /// </value>
        [JsonPropertyName("updatesFromKeenthemes")]
        public UpdatesFromKeenthemes UpdatesFromKeenthemes { get; set; }
    }
}
