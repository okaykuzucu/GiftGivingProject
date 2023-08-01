using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Dtos
{
    public class AcceptedMarketplacesUpdateDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the accepted marketplaces updat options.
        /// </summary>
        /// <value>
        /// The accepted marketplaces updat options.
        /// </value>
        public AcceptedMarketplacesUpdateOptions AcceptedMarketplacesUpdatOptions { get; set; }
    }
}
