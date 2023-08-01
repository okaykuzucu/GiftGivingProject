using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Dtos
{
    public class EventNotificationUpdateDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the event notification update options.
        /// </summary>
        /// <value>
        /// The event notification update options.
        /// </value>
        public EventNotificationUpdateOptions EventNotificationUpdateOptions { get; set; }
    }
}
