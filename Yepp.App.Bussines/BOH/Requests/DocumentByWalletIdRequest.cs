using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Document/ GetDocumentByWalletId 
    /// </summary>
    public class DocumentByWalletIdRequest
    {
        /// <summary>
        /// Gets or sets the wallet identifier.
        /// </summary>
        /// <value>
        /// The wallet identifier.
        /// </value>
        public int walletId { get; set; }
    }
}
