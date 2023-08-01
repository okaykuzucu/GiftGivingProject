using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    public class Shipper : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipper"/> class.
        /// </summary>
        /// <param name="shipperEntity">The shipper entity.</param>
        public Shipper(ShipperEntity shipperEntity)
        {
            this.Id = shipperEntity.Id;
            this.AddressId = shipperEntity.AddressId;
            this.CreatedDate = DateTime.UtcNow;
            this.Name = shipperEntity.Name;
            this.TaxNumber = shipperEntity.TaxNumber;
            this.TaxOffice = shipperEntity.TaxOffice;
            this.UpdatedDate = DateTime.UtcNow;

        }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the tax number.</summary>
        /// <value>The tax number.</value>
        [JsonProperty("tax_number")]
        public int TaxNumber { get; set; }

        /// <summary>Gets or sets the tax office.</summary>
        /// <value>The tax office.</value>
        [JsonProperty("tax_office")]
        public string TaxOffice { get; set; }

        /// <summary>Gets or sets the address identifier.</summary>
        /// <value>The address identifier.</value>
        [JsonProperty("address_id")]
        public Guid AddressId { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }
    }
}
