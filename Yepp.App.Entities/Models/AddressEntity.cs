using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class AddressEntity : BaseEntity
    {
        /// <summary>Gets or sets the user identifier.</summary>
        /// <value>The user identifier.</value>
        [Column("user_id")]
        public Guid UserId { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the street.</summary>
        /// <value>The street.</value>
        [Column("address_line_1")]
        public string AddressLine1 { get; set; }

        /// <summary>Gets or sets the number.</summary>
        /// <value>The number.</value>
        [Column("address_line_2")]
        public string AddressLine2 { get; set; }

        /// <summary>Gets or sets the zipcode.</summary>
        /// <value>The zipcode.</value>
        [Column("zipcode")]
        public int Zipcode { get; set; }

        /// <summary>Gets or sets the city identifier.</summary>
        /// <value>The city identifier.</value>
        [Column("city_id")]
        public Guid CityId { get; set; }

        /// <summary>Gets or sets the country identifier.</summary>
        /// <value>The country identifier.</value>
        [Column("country_id")]
        public Guid CountryId { get; set; }

        /// <summary>Gets or sets the address type identifier.</summary>
        /// <value>The address type identifier.</value>
        [Column("addressestypes_id")]
        public Guid AddressTypeId { get; set; }

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
