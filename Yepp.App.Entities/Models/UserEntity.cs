using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yepp.App.Entities.Models
{
    /// <summary>
    /// User entity
    /// </summary>
    /// <seealso cref="Yepp.App.Entities.BaseEntity" />
    public class UserEntity : BaseEntity
    {
        /// <summary>Gets or sets the role identifier.</summary>
        /// <value>The role identifier.</value>
        [Column("role_id")]
        public Guid RoleId { get; set; }

        /// <summary>Gets or sets the password.</summary>
        /// <value>The password.</value>
        /// <value>The password.</value>
        [Column("password")]
        public string Password { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the surname.</summary>
        /// <value>The surname.</value>
        [Column("surname")]
        public string SurName { get; set; }

        /// <summary>Gets or sets the email.</summary>
        /// <value>The email.</value>
        [Column("email")]
        public string Email { get; set; }

        /// <summary>Gets or sets the telephone.</summary>
        /// <value>The telephone.</value>
        [Column("telephone")]
        public string Telephone { get; set; }

        /// <summary>Gets or sets the image.</summary>
        /// <value>The image.</value>
        [Column("image")]
        public string Image { get; set; }

        /// <summary>Gets or sets the language.</summary>
        /// <value>The language.</value>
        [Column("language")]
        public string Language { get; set; }

        /// <summary>Gets or sets the registration date.</summary>
        /// <value>The registration date.</value>
        [Column("registration_date")]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the IsRegistered.</summary>
        /// <value>The  IsRegistered.</value>
        [Column("is_registered")]
        public bool IsRegistered { get; set; }
        
        /// <summary>
        /// Gets or sets the KVKK checked </summary>
        /// <value>KVKK checked. </value>
        [Column("kvkk_checked")]
        public bool? KvkkChecked { get; set; }
    }
}
