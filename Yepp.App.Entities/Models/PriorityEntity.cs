using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class PriorityEntity : BaseEntity
    {
        /// <summary>Gets or sets the rate.</summary>
        /// <value>The rate.</value>
        [Column("rate")]
        public int Rate { get; set; }
    }
}
