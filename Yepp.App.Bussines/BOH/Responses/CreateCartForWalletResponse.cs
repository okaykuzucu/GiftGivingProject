namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    ///BOH/Wallet/CreateCartForWallet Response
    /// </summary>
    public class CreateCartForWalletResponse
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
        ///	Son kullanıcı için oluşturulan sanal kartın maskeli PAN bilgisi
        /// </summary>
        /// <value>
        /// masked Pan.
        /// </value>
        public string maskedPan { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın id bilgisi
        /// </summary>
        /// <value>
        /// The cardid.
        /// </value>
        public string cardid { get; set; }

        /// <summary>
        /// 	Son kullanıcı için oluşturulan sanal kartın son kullanma tarihi bilgisi
        /// </summary>
        /// <value>
        /// The expiry date.
        /// </value>
        public string expiryDate { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın cvv (güvenlik kodu) bilgisi
        /// </summary>
        /// <value>
        /// The CVV.
        /// </value>
        public string cvv { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın kart adı bilgisi
        /// </summary>
        /// <value>
        /// The name of the card.
        /// </value>
        public string cardName { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın kart tipi bilgisi.
        /// </summary>
        /// <value>
        /// The type of the card.
        /// </value>
        public string cardType { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın kart tipi açıklaması bilgisi.
        /// </summary>
        /// <value>
        /// The card type desc.
        /// </value>
        public string cardTypeDesc { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın statü kodu bilgisidir. 0: Pasif 1: Aktif 2: Freeze 4: Geçici Kapalı 5: ZorunluDokumanOnayı
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string status { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın statü açıklaması bilgisi
        /// </summary>
        /// <value>
        /// The status desc.
        /// </value>
        public string statusDesc { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın statü neden kodu bilgisi
        /// </summary>
        /// <value>
        /// The status reason.
        /// </value>
        public string statusReason { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal karta ait oluşturulma tarihi bilgisi
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public string createdDate { get; set; }
    }
}