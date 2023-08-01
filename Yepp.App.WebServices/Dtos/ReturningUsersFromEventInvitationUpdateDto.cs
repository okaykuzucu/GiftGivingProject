using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Dtos
{
    public class ReturningUsersFromEventInvitationUpdateDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }


        /// <summary>
        /// Gets or sets the returning users from event invitation update options.
        /// </summary>
        /// <value>
        /// The returning users from event invitation update options.
        /// </value>
        public ReturningUsersFromEventInvitationUpdateOptions ReturningUsersFromEventInvitationUpdateOptions { get; set; }
    }
}
