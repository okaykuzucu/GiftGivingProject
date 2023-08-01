using Newtonsoft.Json;
using System;


namespace Yepp.App.Services.Models
{
    public class EmailListUpdateOptions
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }
    }
}
