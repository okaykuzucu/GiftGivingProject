using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    /// <summary>
    /// BOH//WALLET// Freeze Enum
    /// </summary>
    public enum FreezeEnum
    {
        /// <summary>
        /// Kayıt bulunamadı.
        /// </summary>
        E000 = 1,

        /// <summary>
        /// Cüzdan id'si zorunludur.
        /// </summary>
        E006 = 7,

        /// <summary>
        /// Kullanıcı bilgilerinde hata vardır. Servis sağlayıcınız ile görüşünüz.
        /// </summary>
        E013 = 14,

        /// <summary>
        /// Cüzdan durumu kapalıdır.
        /// </summary>
        E037 = 38,
    }
}
