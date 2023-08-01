using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    public class LoadWithAccountRequest
    {
        /// <summary>
        /// Birleşik Ödeme tarafından oluşturulan benzersiz (unique) işlem kaydı bilgisidir. Her işlem için PreLoad methodundan dönen processGuid değeri kullanılmalıdır.
        /// </summary>
        /// <value>
        /// The process GUID.
        /// </value>
        public string processGuid { get; set; }

        /// <summary>
        /// İlgili işlem için son kullanıcının beyan ettiği tutar ve gönderdiği tutar arasındaki kontrolünü yapar.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [match amounts]; otherwise, <c>false</c>.
        /// </value>
        public bool matchAmounts { get; set; }

        /// <summary>
        /// Müşteri cüzdan Idsi.
        /// </summary>
        /// <value>
        /// The walletid.
        /// </value>
        public string walletid { get; set; }

        /// <summary>
        /// İş ortaklarımızın GetBank servisinden işleme devam edeceği bankaların IBAN bilgisidir.
        /// </summary>
        /// <value>
        /// The internediate iban.
        /// </value>
        public string IntermediateIban { get; set; }

        /// <summary>
        /// İş ortaklarımızın komisyon bilgilendirmesinden sonra müşterilerine gösterdiği yükleme tutar bilgisidir.
        /// </summary>
        /// <value>
        /// The load amount.
        /// </value>
        public int loadAmount { get; set; }
    }
}
