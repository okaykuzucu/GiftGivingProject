using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class AddressTypeEntity : BaseEntity
    {

        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        [Column("type")]
        public string Type { get; set; }
    }
}
