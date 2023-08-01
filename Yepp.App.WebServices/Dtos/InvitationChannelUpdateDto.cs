using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Controllers
{
    public class InvitationChannelUpdateDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the invitation channel update options.
        /// </summary>
        /// <value>
        /// The invitation channel update options.
        /// </value>
        public InvitationChannelUpdateOptions InvitationChannelUpdateOptions { get; set; }
    }
}
