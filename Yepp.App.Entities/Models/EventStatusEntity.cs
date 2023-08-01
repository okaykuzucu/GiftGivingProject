using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntity" />
    public class EventStatusEntity : BaseEntity
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Column("name")]
        public string Name { get; set; }
    }
}
