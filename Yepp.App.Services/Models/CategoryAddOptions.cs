﻿using Newtonsoft.Json;
using System;

namespace Yepp.App.Services.Models
{
    public class CategoryAddOptions
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [JsonProperty("created_date")]
        public DateTime Created_date { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime Updated_date { get; set; }
    }
}
