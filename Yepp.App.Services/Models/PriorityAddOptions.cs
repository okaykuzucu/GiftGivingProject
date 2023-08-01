﻿using Newtonsoft.Json;

namespace Yepp.App.Services.Models
{
    public class PriorityAddOptions
    {
        /// <summary>Gets or sets the rate.</summary>
        /// <value>The rate.</value>
        [JsonProperty("rate")]
        public int Rate { get; set; }
    }
}
