using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class ShipperEntity : BaseEntity
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the tax number.</summary>
        /// <value>The tax number.</value>
        [Column("tax_number")]
        public int TaxNumber { get; set; }

        /// <summary>Gets or sets the tax office.</summary>
        /// <value>The tax office.</value>
        [Column("tax_office")]
        public string TaxOffice { get; set; }

        /// <summary>Gets or sets the address identifier.</summary>
        /// <value>The address identifier.</value>
        [Column("address_id")]
        public Guid AddressId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }
    }
}
