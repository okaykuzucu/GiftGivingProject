using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    public class PreLoadRequest
    {
        /// <summary>
        /// Müşteri cüzdan Idsi
        /// </summary>
        /// <value>
        /// The walletid.
        /// </value>
        public string walletid { get; set; }

        /// <summary>
        /// Bakiye yükleme işlem açıklamasıdır. İş ortaklarımızın müşterilerinin işlem anındaki açıklama bilgisinin gönderilmesini sağlar.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string description { get; set; }

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
        /// Bakiye yükleme işleminin kaynak bilgisidir. 1: masterpass, 2: account, 3 : vpos
        /// </summary>
        /// <value>
        /// The type of the load.
        /// </value>
        public int loadType { get; set; }

        /// <summary>
        /// Bakiye yükleme işlem numarası bilgisidir. İş ortaklarımızın kendi taraflarındaki oluşturulacak işlemin unique (benzersiz) olduğunu ifade eder. Preload servisinde sadece loadType = 1 yani masterpass olması durumunda zorunludur. Bunun dışında opsiyoneldir.
        /// </summary>
        /// <value>
        /// The order no.
        /// </value>
        public string orderNo { get; set; }
    }
}
