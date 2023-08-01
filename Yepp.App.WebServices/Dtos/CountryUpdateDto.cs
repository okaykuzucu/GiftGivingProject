﻿using Yepp.App.Services.Models;

namespace Yepp.App.WebServices.Dtos
{
    public class CountryUpdateDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the address update options.
        /// </summary>
        /// <value>
        /// The address update options.
        /// </value>
        public CountryUpdateOptions CountryUpdateOptions { get; set; }
    }
}
