using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class CityEntity : BaseEntity
    {

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the country identifier.</summary>
        /// <value>The country identifier.</value>
        [Column("country_id")]
        public Guid CountryId { get; set; }

    }
}
