using Newtonsoft.Json;
using System;
using Yepp.App.Entities.Models;

namespace Yepp.App.Services.Models
{
    /// <summary>
    /// The User
    /// </summary>
    /// <seealso cref="Yepp.App.Services.BaseEntity" />
    public class User : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="userEntity">The user entity.</param>
        public User(UserEntity userEntity) 
        {
            this.Id = userEntity.Id;
            this.RoleId = userEntity.RoleId;
            this.CreatedDate = userEntity.CreatedDate;
            this.Email = userEntity.Email;
            this.Password = userEntity.Password;
            this.RegistrationDate = userEntity.RegistrationDate;
            this.SurName = userEntity.SurName;
            this.Telephone = userEntity.Telephone;
            this.UpdatedDate = userEntity.UpdatedDate;
            this.Image = userEntity.Image;
            this.IsRegistered = userEntity.IsRegistered;
            this.Language = userEntity.Language;
            this.Name = userEntity.Name;
            this.RegistrationDate = userEntity.RegistrationDate;
        }
        /// <summary>Gets or sets the role identifier.</summary>
        /// <value>The role identifier.</value>
        [JsonProperty("role_id")]
        public Guid RoleId { get; set; }

        /// <summary>Gets or sets the password.</summary>
        /// <value>The password.</value>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Gets or sets the surname.</summary>
        /// <value>The surname.</value>
        [JsonProperty("surname")]
        public string SurName { get; set; }

        /// <summary>Gets or sets the email.</summary>
        /// <value>The email.</value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>Gets or sets the telephone.</summary>
        /// <value>The telephone.</value>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        /// <summary>Gets or sets the image.</summary>
        /// <value>The image.</value>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>Gets or sets the language.</summary>
        /// <value>The language.</value>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>Gets or sets the registration date.</summary>
        /// <value>The registration date.</value>
        [JsonProperty("registration_date")]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets the IsRegistered.</summary>
        /// <value>The  IsRegistered.</value>
        [JsonProperty("is_registered")]
        public bool IsRegistered { get; set; }

        /// <summary>Gets or sets the IsRegistered.</summary>
        /// <value>The  IsRegistered.</value>
        [JsonProperty("Kvkk_Checked")]
        public bool KvkkChecked { get; set; }
    }
}
