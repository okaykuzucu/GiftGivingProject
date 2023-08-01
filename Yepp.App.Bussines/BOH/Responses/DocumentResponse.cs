using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH/Document/ Document Response
    /// </summary>
    public class DocumentResponse
    {
        /// <summary>
        /// İşlemin başarılı olma durumu
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is succes; otherwise, <c>false</c>.
        /// </value>
        public bool isSucces { get; set; }

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
        public string requestId { get; set;}

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object data { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin ID bilgisi. 
        /// 1: Uzaktan Erişim 2: Rıza Metni 3: Çerçeve Sözleşme 4: KVKK
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int id { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin adı
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin beyanı
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string text { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin bulunduğu URL bilgisi
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string url { get; set; }

        /// <summary>
        /// Metnin onaylanması için kullanılacak belirteç. Her zaman true olmalıdı
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is required; otherwise, <c>false</c>.
        /// </value>
        public bool isRequired { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin Birleşik Ödeme tarafından oluşturulan doküman tipidir. 1: Sözleşme
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public int documentType { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin doküman açıklamasıdır.
        /// </summary>
        /// <value>
        /// The document type desc.
        /// </value>
        public string DocumentTypeDesc { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin versiyon bilgisi
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public string version { get; set; }

        /// <summary>
        /// Son kullanıcı tarafından okuyup onaylanacak metnin son onaylama tarihi bilgisi
        /// </summary>
        /// <value>
        /// The expire date.
        /// </value>
        public string expireDate { get; set; }
    }
}
