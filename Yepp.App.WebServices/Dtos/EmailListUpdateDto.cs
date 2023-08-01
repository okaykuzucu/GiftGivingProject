using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Dtos
{
    public class EmailListUpdateDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the email list update options.
        /// </summary>
        /// <value>
        /// The email list update options.
        /// </value>
        public EmailListUpdateOptions EmailListUpdateOptions { get; set; }
    }
}
