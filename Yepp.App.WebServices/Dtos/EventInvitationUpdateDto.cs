using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Dtos
{
    public class EventInvitationUpdateDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the event invitation update options.
        /// </summary>
        /// <value>
        /// The event invitation update options.
        /// </value>
        public EventInvitationUpdateOptions EventInvitationUpdateOptions { get; set; }
    }
}
