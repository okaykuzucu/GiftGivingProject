using Newtonsoft.Json;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class Role : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        /// <param name="roleEntity">The role entity.</param>
        public Role(RoleEntity roleEntity)
        {
            this.Id = roleEntity.Id;
            this.Name = roleEntity.Name;
        }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
