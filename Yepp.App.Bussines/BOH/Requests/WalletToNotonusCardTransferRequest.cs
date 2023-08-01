using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    public class WalletToNotonusCardTransferRequest
    {
        /// <summary>
        /// Birleşik Ödeme tarafından oluşturulan benzersiz (unique) işlem kaydı bilgisidir. Her işlem için PreTransfer methodundan dönen processGuid değeri kullanılmalıdır.
        /// </summary>
        /// <value>
        /// The process GUID.
        /// </value>
        public string processGuid { get; set; }

        /// <summary>
        /// İlgili işlem için alıcı kart numarası (PAN) bilgisidir.
        /// </summary>
        /// <value>
        /// The card number.
        /// </value>
        public string cardNumber { get; set; }

        /// <summary>
        /// Bakiye transfer işleminin OTP'li (true) veya OTP'siz (false) devam edilmesini sağlar.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [otp verify]; otherwise, <c>false</c>.
        /// </value>
        public bool otpVerify { get; set; }
    }
}
