using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH//WALLET//Freeze Response
    /// </summary>
    public class FreezeResponse
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
        public string requestId { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public string data { get; set; }

    }
}
