using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    public class WalletToNotonusCardTransferOtpVerifyRequest
    {
        /// <summary>
        /// Birleşik Ödeme tarafından oluşturulan benzersiz (unique) işlem kaydı bilgisidir. Her işlem için PreTransfer methodundan dönen processGuid değeri kullanılmalıdır.
        /// </summary>
        /// <value>
        /// The process GUID.
        /// </value>
        public string processGuid { get; set; }

        /// <summary>
        /// Son kullanıcının telefonuna gelen OTP kodudur.
        /// </summary>
        /// <value>
        /// The verify code.
        /// </value>
        public int verifyCode { get; set; }
    }
}
