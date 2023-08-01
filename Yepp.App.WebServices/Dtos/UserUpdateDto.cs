using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Dtos
{
    /// <summary>
    /// The User Update Dto
    /// </summary>
    public class UserUpdateDto
    {

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the user update options.
        /// </summary>
        /// <value>
        /// The user update options.
        /// </value>
        public UserUpdateOptions UserUpdateOptions { get; set; }

    }
}
