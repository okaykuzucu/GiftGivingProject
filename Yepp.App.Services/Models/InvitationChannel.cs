using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{ 
    public class InvitationChannel : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationChannel"/> class.
        /// </summary>
        /// <param name="invitationChannelEntity">The ınvitation channel entity.</param>
        public InvitationChannel(InvitationChannelEntity invitationChannelEntity )
        {
            this.CreatedDate = DateTime.UtcNow;
            this.Name = invitationChannelEntity.Name;
            this.UpdatedDate = DateTime.UtcNow;
            this.Id = invitationChannelEntity.Id;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>
        /// The updated date.
        /// </value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

    }
}
