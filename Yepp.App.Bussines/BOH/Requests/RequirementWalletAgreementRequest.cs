using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Document/ RequirementWalletAgreement Request
    /// </summary>
    public class RequirementWalletAgreementRequest
    {
        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının ID bilgisi
        /// </summary>
        /// <value>
        /// The wallet identifier.
        /// </value>
        public string walletId { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin ID bilgisi. 
        /// 1: Uzaktan Erişim 2: Rıza Metni 3: Çerçeve Sözleşme 4: KVKK
        /// </summary>
        /// <value>
        /// The document identifier.
        /// </value>
        public int docId { get; set; }

        /// <summary>
        /// Metnin onaylandığını gösteren belirteç
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is accepted; otherwise, <c>false</c>.
        /// </value>
        public bool isAccepted { get; set; }
    }
}
