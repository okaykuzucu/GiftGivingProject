using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Wallet/ Remove Request
    /// </summary>
    public class RemoveRequest
    {
        /// <summary>
        /// Cüzdan sahibi son kullanıcının telefon numarası
        /// </summary>
        /// <value>
        /// The msisdn.
        /// </value>
        public string msisdn { get; set; }

    }
}
