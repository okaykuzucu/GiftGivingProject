using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH/Wallet/ Create Response
    /// </summary>
    public class CreateResponse
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
        public object data { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının ID bilgisi
        /// </summary>
        /// <value>
        /// The wallet identifier.
        /// </value>
        public string walletId { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının oluşturulma tarihi
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public string createdDate { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının tipi. 
        /// Standart: Kişiselleştirilmemiş Premium: Kişiselleştirilmiş
        /// </summary>
        /// <value>
        /// The type of the account.
        /// </value>
        public string accountType { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının Türk Lirası (TL) bakiyesi
        /// </summary>
        /// <value>
        /// The balance tl.
        /// </value>
        public int balanceTL { get; set; }

        /// <summary>
        /// 	Son kullanıcı için oluşturulan cüzdan hesabının Amerikan Doları (USD) bakiyesi
        /// </summary>
        /// <value>
        /// The balance usd.
        /// </value>
        public int balanceUSD { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının Euro (EUR) bakiyesi
        /// </summary>
        /// <value>
        /// The balance eur.
        /// </value>
        public int balanceEUR { get; set; }

    }
}
