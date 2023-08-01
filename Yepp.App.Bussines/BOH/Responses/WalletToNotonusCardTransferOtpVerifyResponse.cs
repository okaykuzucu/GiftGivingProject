using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    public class WalletToNotonusCardTransferOtpVerifyResponse
    {
        /// <summary>
        /// İşlemin başarılı olma durumu
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        public bool isSuccess { get; set; }

        /// <summary>
        /// İşlem hata kodu
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public string errorCode { get; set; }

        /// <summary>
        /// İşlem sonuç mesajı
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string message { get; set; }

        /// <summary>
        /// İstek işleminin unique log Id bilgisi
        /// </summary>
        /// <value>
        /// The request identifier.
        /// </value>
        public string requestId { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object data { get; set; }

        /// <summary>
        /// Benzersiz (unique) işlem kaydı bilgisidir.
        /// </summary>
        /// <value>
        /// The process GUID.
        /// </value>
        public string processGuid { get; set; }

        /// <summary>
        /// İş ortaklarımızın komisyon bilgilendirmesinden sonra müşterilerine gösterdiği bakiye transfer tutar bilgisidir.
        /// </summary>
        /// <value>
        /// The transfer amount.
        /// </value>
        public int transferAmount { get; set; }

        /// <summary>
        /// Son kullanıcıya yansıtılan komisyon tutarı bilgisidir.
        /// </summary>
        /// <value>
        /// The customer commission amount.
        /// </value>
        public int customerCommissionAmount { get; set; }

        /// <summary>
        /// Partner kuruma yansıtılan komisyon tutarı bilgisidir.
        /// </summary>
        /// <value>
        /// The partner commission amount.
        /// </value>
        public int partnerCommissionAmount { get; set; }
    }
}
