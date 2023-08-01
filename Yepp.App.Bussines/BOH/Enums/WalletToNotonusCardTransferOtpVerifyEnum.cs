using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    public enum WalletToNotonusCardTransferOtpVerifyEnum
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
        /// Process Guid alanı zorunludur.
        /// </summary>
        E029 = 30,

        /// <summary>
        /// Kişiselleştirme işlemi yapılmamış cüzdandan transfer yapılamaz.
        /// </summary>
        E041 = 42,

        /// <summary>
        /// Lütfen tek seferlik oluşturulan doğrulama kodunu giriniz.
        /// </summary>
        E047 = 48,

        /// <summary>
        /// Girdiğiniz doğrulama kodu hatalıdır. Lütfen kontrol ederek tekrar deneyiniz.
        /// </summary>
        E048 = 49,

        /// <summary>
        /// Girdiğiniz doğrulama kodu kullanılmıştır. Lütfen kontrol ederek tekrar deneyiniz.
        /// </summary>
        E049 = 50,

        /// <summary>
        /// Girdiğiniz doğrulama kodu geçersizdir. Lütfen kontrol ederek tekrar deneyiniz.
        /// </summary>
        E050 = 51,

        /// <summary>
        /// ProcessGuid daha önce kullanılmış.
        /// </summary>
        E053 = 54,

        /// <summary>
        /// Money transfer servisinde hata aldı.
        /// </summary>
        E089 = 90,
    }
}
