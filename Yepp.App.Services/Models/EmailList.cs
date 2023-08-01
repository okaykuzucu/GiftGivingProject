using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class EmailList : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailList"/> class.
        /// </summary>
        /// <param name="emailListEntity">The email list entity.</param>
        public EmailList(EmailListEntity emailListEntity)
        {
            this.Id = emailListEntity.Id;
            this.CreatedDate = emailListEntity.CreatedDate;
            this.Email = emailListEntity.Email;
        }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
