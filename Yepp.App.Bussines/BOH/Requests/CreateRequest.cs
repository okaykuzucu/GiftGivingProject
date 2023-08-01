using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Wallet/ Create Request
    /// </summary>
    public class CreateRequest
    {
        /// <summary>
        /// Cüzdan sahibi son kullanıcının telefon numarası
        /// </summary>
        /// <value>
        /// The msisdn.
        /// </value>
        public string msisdn { get; set; }

        /// <summary>
        /// Gets or sets the documents.
        /// </summary>
        /// <value>
        /// The documents.
        /// </value>
        public object documents { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin ID bilgisi. 
        /// 1: Uzaktan Erişim 2: Rıza Metni 3: Çerçeve Sözleşme 4: KVKK
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int id { get; set; }

        /// <summary>
        /// Metnin onaylandığını gösteren belirteç
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is accepted; otherwise, <c>false</c>.
        /// </value>
        public bool isAccepted { get; set; }

    }
}
