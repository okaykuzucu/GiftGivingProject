using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    public class LoadWithVPOSRequest
    {
        /// <summary>
        /// Birleşik Ödeme tarafından oluşturulan benzersiz (unique) işlem kaydı bilgisidir. Her işlem için PreLoad methodundan dönen processGuid değeri kullanılmalıdır.
        /// </summary>
        /// <value>
        /// The process GUID.
        /// </value>
        public string processGuid { get; set; }

        /// <summary>
        /// Müşteri cüzdan Idsi
        /// </summary>
        /// <value>
        /// The walletid.
        /// </value>
        public string walletid { get; set; }

        /// <summary>
        /// GBakiye yükleme işlem açıklamasıdır. İş ortaklarımızın müşterilerinin işlem anındaki açıklama bilgisinin gönderilmesini sağlar.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string description { get; set; }

        /// <summary>
        /// İstemci IP bilgisidir. null gönderilebilir.
        /// </summary>
        /// <value>
        /// The request ip.
        /// </value>
        public string requestIp { get; set; }

        /// <summary>
        /// İşlem başarılı olduğunda iş ortağına dönülecek url bilgisidir.
        /// </summary>
        /// <value>
        /// The ok URL.
        /// </value>
        public string okUrl { get; set; }

        /// <summary>
        /// İşlem başarısız olduğunda iş ortağına dönülecek url bilgisidir.
        /// </summary>
        /// <value>
        /// The fail URL.
        /// </value>
        public string failUrl { get; set; }

    }
}
