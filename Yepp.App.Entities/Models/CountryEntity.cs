using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class CountryEntity : BaseEntity
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the iso.</summary>
        /// <value>The iso.</value>
        [Column("iso")]
        public string Iso { get; set; }
    }
}
