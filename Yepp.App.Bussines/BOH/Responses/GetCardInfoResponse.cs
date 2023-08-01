using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH/Wallet/GetCardInfo Response
    /// </summary>
    public class GetCardInfoResponse
    {
        /// <summary>
        /// İşlemin başarılı olma durumu
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        public bool isSuccess { get; set; }

        /// <summary>
        /// 	İşlem hata kodu
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public string errorCode { get; set; }

        /// <summary>
        /// 	İşlem sonuç mesajı
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string message { get; set; }

        /// <summary>
        ///İstek işleminin unique log Id bilgisi
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
        ///	Son kullanıcı için oluşturulan sanal kartın şifreli PAN (kart numarası) bilgisi
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string pan { get; set; }

        /// <summary>
        ///Son kullanıcı için oluşturulan sanal kartın şifreli cvv (güvenlik kodu) bilgisi
        /// </summary>
        /// <value>
        /// The CVV.
        /// </value>
        public string cvv { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın şifreli son kullanma tarihi bilgisi
        /// </summary>
        /// <value>
        /// The expiry date.
        /// </value>
        public string expiryDate { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın şifreli id bilgisi
        /// </summary>
        /// <value>
        /// The cardid.
        /// </value>
        public string cardid { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın şifreli id bilgisi
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        public string statusCode { get; set; }
    }
}