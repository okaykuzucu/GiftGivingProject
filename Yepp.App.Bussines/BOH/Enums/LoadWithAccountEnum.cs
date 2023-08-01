using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    public enum LoadWithAccountEnum
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
        /// Para Yükleme bilgileri hatalıdır.
        /// </summary>
        E032 = 33,

        /// <summary>
        /// Nöbetçi Transfer servisi hata aldı.
        /// </summary>
        E035 = 36,

        /// <summary>
        /// Bakiye yükleme servisi ilgili process guid için çağrılmıştır.
        /// </summary>
        E042 = 43,

        /// <summary>
        /// ProcessGuid daha önce kullanılmış.
        /// </summary>
        E053 = 54,
    }
}
