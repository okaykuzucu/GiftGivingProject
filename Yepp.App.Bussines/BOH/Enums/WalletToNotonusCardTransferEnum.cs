using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    public enum WalletToNotonusCardTransferEnum
    {
        /// <summary>
        /// Kayıt bulunamadı.
        /// </summary>
        E000 = 1,

        /// <summary>
        /// Kullanıcı bilgilerinde hata vardır. Servis sağlayıcınız ile görüşünüz.
        /// </summary>
        E013 = 14,

        /// <summary>
        /// Cüzdan bilgisi bulunamadı.
        /// </summary>
        E014 = 15,

        /// <summary>
        /// Cüzdan durumu kişiselleştirme işlemi için uygun değildir.
        /// </summary>
        E022 = 23,

        /// <summary>
        /// Cüzdan için kalan tutar bilgisi bulunamadı.
        /// </summary>
        E025 = 26,

        /// <summary>
        /// {0} tutarını aşamazsınız.
        /// </summary>
        E026 = 27,

        /// <summary>
        /// Kişiselleştirme bilgisi bulunamadı.
        /// </summary>
        E028 = 29,

        /// <summary>
        /// Process Guid alanı zorunludur.
        /// </summary>
        E029 = 30,

        /// <summary>
        /// Kişiselleştirme işlemi yapılmamış cüzdandan transfer yapılamaz.
        /// </summary>
        E041 = 42,

        /// <summary>
        /// Transfer edilecek tutar doğru girilmelidir.
        /// </summary>
        E045 = 46,

        /// <summary>
        /// recieverIBAN alanı zorunludur.
        /// </summary>
        E046 = 47,

        /// <summary>
        /// ProcessGuid daha önce kullanılmış.
        /// </summary>
        E053 = 54,

        /// <summary>
        /// İlgili işlem için cüzdan bakiyeniz hesaba para çıkma işlemi için yetersizdir.
        /// </summary>
        E062 = 63,

        /// <summary>
        /// OTP kontrolü zorunludur.
        /// </summary>
        E063 = 64,

        /// <summary>
        /// Müşteri en az bir kez OTP doğrulamalıdır.
        /// </summary>
        E064 = 65,

        /// <summary>
        /// Money transfer servisinde hata aldı.
        /// </summary>
        E089 = 90,

        /// <summary>
        /// Kart numarası zorunludur.
        /// </summary>
        E093 = 94,

        /// <summary>
        /// Kart numarası maksimum 16 hane olarak girilmelidir.
        /// </summary>
        E102 = 103,

        /// <summary>
        /// Kart bilgisi doğrulanamadı.
        /// </summary>
        E106 = 107,

    }
}
