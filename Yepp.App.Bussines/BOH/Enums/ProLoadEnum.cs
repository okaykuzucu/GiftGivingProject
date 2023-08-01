using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    public enum ProLoadEnum
    {
        /// <summary>
        /// Cüzdan id'si zorunludur.
        /// </summary>
        E006 = 7,

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
        /// Komisyon profili bulunamadı.
        /// </summary>
        E027 = 28,

        /// <summary>
        /// Kişiselleştirme bilgisi bulunamadı.
        /// </summary>
        E028 = 29,

        /// <summary>
        /// Type alanını doğru girilmelidir.
        /// </summary>
        E044 = 45,

    }
}
