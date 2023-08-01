using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    public class WalletToWalletTransferRequest
    {
        /// <summary>
        /// Birleşik Ödeme tarafından oluşturulan benzersiz (unique) işlem kaydı bilgisidir. Her işlem için PreTransfer methodundan dönen processGuid değeri kullanılmalıdır.
        /// </summary>
        /// <value>
        /// The process GUID.
        /// </value>
        public string processGuid { get; set; }

        /// <summary>
        /// İş ortaklarımızın komisyon bilgilendirmesinden sonra müşterilerine gösterdiği bakiye transfer itutar bilgisidir.
        /// </summary>
        /// <value>
        /// The transfer amount.
        /// </value>
        public int transferAmount { get; set; }

        /// <summary>
        /// Bakiye transfer işlem açıklamasıdır. İş ortaklarımızın müşterilerinin işlem anındaki açıklama bilgisinin gönderilmesini sağlar.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string description { get; set; }
    }
}
