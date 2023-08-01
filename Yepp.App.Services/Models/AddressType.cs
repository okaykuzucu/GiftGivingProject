using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AddressType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressType"/> class.
        /// </summary>
        /// <param name="addressTypeEntity">The address type entity.</param>
        public AddressType(AddressTypeEntity addressTypeEntity)
        {
            this.Type = addressTypeEntity.Type;
            this.Id = addressTypeEntity.Id;
            
        }
        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
