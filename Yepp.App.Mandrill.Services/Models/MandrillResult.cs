using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yepp.App.Mandrill.Services.Models
{
    /// <summary>
    /// Mandril Result Object
    /// </summary>
    public class MandrillResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is ok.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is ok; otherwise, <c>false</c>.
        /// </value>
        public bool IsOk { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }
    }
}