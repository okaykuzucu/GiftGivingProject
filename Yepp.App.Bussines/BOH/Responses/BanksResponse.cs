using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    public class BanksResponse
    {
        /// <summary>
        /// İşlemin başarılı olma durumu.
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

        /// <summary>
        /// Gets or sets the banks.
        /// </summary>
        /// <value>
        /// The banks.
        /// </value>
        public Array banks { get; set; }

        /// <summary>
        /// Banka adı bilgisidir.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Hesap IBAN bilgisidir.
        /// </summary>
        /// <value>
        /// The iban.
        /// </value>
        public string iban { get; set; }

        /// <summary>
        /// GHesap döviz kodu bilgisidir. 949: Türk Lirası 840: Amerikan Doları 978: Euro
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        public int currencyCode { get; set; }

        /// <summary>
        /// Hesap döviz kodu açıklama bilgisidir. TRY: Türk Lirası USD: Amerikan Doları EUR: Euro
        /// </summary>
        /// <value>
        /// The currency code desc.
        /// </value>
        public string currencyCodeDesc { get; set; }

        /// <summary>
        /// Hesap aktiflik bilgisidir. Not: Kapalı Both: Hem borç hem alacak hareketi Sender: Alacak hareketi Reciever: Borç hareketi
        /// </summary>
        /// <value>
        /// The state of the active.
        /// </value>
        public string activeState { get; set; }

        /// <summary>
        /// Banka EFT kodu bilgisidir.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public string bankID { get; set; }

        /// <summary>
        /// Alıcı kurum bilgisidir.
        /// </summary>
        /// <value>
        /// The name of the receiver.
        /// </value>
        public string receiverName { get; set; }
    }
}
