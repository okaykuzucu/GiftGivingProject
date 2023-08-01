using Newtonsoft.Json;
using System;

namespace Yepp.App.Entities
{
    /// <summary>
    /// The entity
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        Guid Id { get; set; }
    }
}
