using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH//WALLET//Freeze Request
    /// </summary>
    public class FreezeRequest
    {
        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının ID bilgisi
        /// </summary>
        /// <value>
        /// The wallet identifier.
        /// </value>
        public string walletId { get; set; }
    }
}
