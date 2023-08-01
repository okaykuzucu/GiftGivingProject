using Newtonsoft.Json;
using System;

namespace Yepp.App.Services
{
    public abstract class  BaseEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("Id")]
        public Guid Id { get; set; }
    }
}
