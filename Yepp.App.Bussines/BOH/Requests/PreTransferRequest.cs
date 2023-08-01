using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    public class PreTransferRequest
    {
        /// <summary>
        /// Gönderici müşteri cüzdan Id bilgisidir.
        /// </summary>
        /// <value>
        /// From walletid.
        /// </value>
        public string fromWalletid { get; set; }

        /// <summary>
        /// Alıcı müşteri cüzdan Id bilgisidir. transferType = 2 (Cüzdandan cüzdana transfer olması durumunda bu alanın gönderilmesi gerekmektedir.
        /// </summary>
        /// <value>
        /// To walletid.
        /// </value>
        public string toWalletid { get; set; }

        /// <summary>
        /// Bakiye yükleme işlem tutarı bilgisidir.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public int amount { get; set; }

        /// <summary>
        /// Bakiye yükleme işlem döviz kuru bilgisidir. 949: Türk Lirası 840: Amerikan Doları 978: Euro
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        public int currencyCode { get; set; }

        /// <summary>
        /// Bakiye yükleme işleminin kaynak bilgisidir. 1: Cüzdandan banka hesabına, 2: Cüzdandan cüzdana, 3: Cüzdandan Karta
        /// </summary>
        /// <value>
        /// The type of the transfer.
        /// </value>
        public int transferType { get; set; }

        /// <summary>
        /// Bakiye yükleme işlem numarası bilgisidir. İş ortaklarımızın kendi taraflarındaki oluşturulacak işlemin unique (benzersiz) olduğunu ifade eder.
        /// </summary>
        /// <value>
        /// The order no.
        /// </value>
        public string orderNo { get; set; }
    }
}
