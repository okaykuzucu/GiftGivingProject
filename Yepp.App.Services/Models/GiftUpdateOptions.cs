﻿using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    public class GiftUpdateOptions
    {
        /// <summary>Gets or sets the event identifier.</summary>
        /// <value>The event identifier.</value>
        [JsonProperty("event_id")]
        public Guid EventId { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the description.</summary>
        /// <value>The description.</value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>Gets or sets the price.</summary>
        /// <value>The price.</value>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>Gets or sets the quantity.</summary>
        /// <value>The quantity.</value>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        /// <summary>Gets or sets the link.</summary>
        /// <value>The link.</value>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>Gets or sets the image.</summary>
        /// <value>The image.</value>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the priority identifier.</summary>
        /// <value>The priority identifier.</value>
        [JsonProperty("priority_id")]
        public Guid PriorityId { get; set; }
    }
}
