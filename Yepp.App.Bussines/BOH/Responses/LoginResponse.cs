namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH/Auth/ Login Response
    /// </summary>
    public class LoginResponse
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
        ///	Doğrulama token değeri
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string token { get; set; }

        /// <summary>
        ///	Doğrulama token tipi
        /// </summary>
        /// <value>
        /// The type of the token.
        /// </value>
        public string tokenType { get; set; }

        /// <summary>
        ///	Token son kullanma zamanı
        /// </summary>
        /// <value>
        /// The expire date.
        /// </value>
        public string expireDate { get; set; }

        /// <summary>
        /// Login olan kullanıcı isim soyisim bilgisi
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }
    }
}