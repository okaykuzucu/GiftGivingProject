using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    public enum WalletToAccountTransferEnum
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
        /// Tutar alanı 0 dan büyük olmalıdır.
        /// </summary>
        E023 = 24,

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
        /// Nöbetçi Transfer servisi hata aldı.
        /// </summary>
        E035 = 36,

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
        /// ReceiverIBAN formatı hatalıdır.
        /// </summary>
        E054 = 55,

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
        /// Girdiğiniz IBAN, kimlik bilgilerinizle uyuşmamaktadır. Lütfen kontrol ederek tekrar deneyiniz.
        /// </summary>
        E118 = 119,

    }
}
