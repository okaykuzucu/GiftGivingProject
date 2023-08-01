using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH/Document/ Perso Response
    /// </summary>
    public class PersoResponse
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
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public object customer { get; set; }

        /// <summary>
        /// Son kullanıcı için kişiselleştirilen cüzdana ait müşteri ID bilgisi
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string id { get; set; }

        /// <summary>
        /// Son kullanıcı için kişiselleştirilen cüzdana ait müşteri segmenti.
        /// B: Bireysel K: Kurumsal
        /// </summary>
        /// <value>
        /// The customer segment.
        /// </value>
        public string customerSegment { get; set; }

        /// <summary>
        /// Gets or sets the wallet.
        /// </summary>
        /// <value>
        /// The wallet.
        /// </value>
        public object wallet { get; set; }

        /// <summary>
        /// Son kullanıcı için kişiselleştirilen cüzdana ait hesabının oluşturulma tarihi
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public string createdDate { get; set; }

        /// <summary>
        /// Son kullanıcı için kişiselleştirilen cüzdana ait hesabın Türk Lirası (TL) bakiyesi
        /// </summary>
        /// <value>
        /// The balance tl.
        /// </value>
        public int balanceTL { get; set; }

        /// <summary>
        /// Son kullanıcı için kişiselleştirilen cüzdana ait hesabın Amerikan Doları (USD) bakiyesi
        /// </summary>
        /// <value>
        /// The balance usd.
        /// </value>
        public int balanceUSD { get; set; }

        /// <summary>
        /// Son kullanıcı için kişiselleştirilen cüzdana ait hesabın Euro (EUR) bakiyesi
        /// </summary>
        /// <value>
        /// The balance eur.
        /// </value>
        public int balanceEUR { get; set; }

        /// <summary>
        /// Son kullanıcı için kişiselleştirilen cüzdana ait hesabının kişiselleştirilme tarihi
        /// </summary>
        /// <value>
        /// The perso date.
        /// </value>
        public string persoDate { get; set; }
    }
}
