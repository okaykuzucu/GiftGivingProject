using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    public class LoadWithVPOS3dRequest
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
        /// Bakiye yükleme işlem açıklamasıdır. İş ortaklarımızın müşterilerinin işlem anındaki açıklama bilgisinin gönderilmesini sağlar.
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


        /// <summary>
        /// İşlem yapılan kredi/banka kartı kart sahibi isim bilgisidir.
        /// </summary>
        /// <value>
        /// The name of the card holder.
        /// </value>
        public string cardHolderName { get; set; }

        /// <summary>
        /// İşlem yapılan kredi/banka kartı PAN (kart numarası) bilgisidir.
        /// </summary>
        /// <value>
        /// The card number.
        /// </value>
        public string cardNumber { get; set; }

        /// <summary>
        /// İşlem yapılan kredi/banka kartı güvenlik kodu (cvv) bilgisidir.
        /// </summary>
        /// <value>
        /// The CVV.
        /// </value>
        public string cvv { get; set; }

        /// <summary>
        /// İşlem yapılan kredi/banka kartı son kullanma yıl bilgisidir. 2025 için 25 girilmelidir.
        /// </summary>
        /// <value>
        /// The expiry date year.
        /// </value>
        public string expiryDateYear { get; set; }

        /// <summary>
        /// İşlem yapılan kredi/banka kartı son kullanma yıl bilgisidir. 2025 için 25 girilmelidir.
        /// </summary>
        /// <value>
        /// The expiry date month.
        /// </value>
        public string expiryDateMonth { get; set; }

        /// <summary>
        /// İşlem yapılan kredi/banka kartı sonraki işlemler için kaydedilmesi istenirse true gönderilmelidir.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [insert card]; otherwise, <c>false</c>.
        /// </value>
        public bool insertCard { get; set; }

        /// <summary>
        /// İşlem yapılan kredi/banka kartı sonraki işlemler için kaydedilmesi istenirse karta isim vermek için kullanılır. insertCard=true gelmesi durumunda zorunludur.
        /// </summary>
        /// <value>
        /// The card alias.
        /// </value>
        public string cardAlias { get; set; }

        /// <summary>
        /// Saklanan kart ID bilgisidir. Kayıtlı bir müşteri kartı ile işlem yapılacaksa bu bilginin doldurulması gerekir.
        /// </summary>
        /// <value>
        /// The secure data identifier.
        /// </value>
        public int secureDataId { get; set; }

        /// <summary>
        /// İşlemin 3D secure veya Non3D olacağını belirtir. true: 3D secure işlem, false: Non 3D Secure.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use3 d]; otherwise, <c>false</c>.
        /// </value>
        public bool use3D { get; set; }


    }
}
