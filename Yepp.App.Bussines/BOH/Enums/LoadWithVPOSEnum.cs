using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    public enum LoadWithVPOSEnum
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
        /// Cüzdan bilgisi bulunamadı.
        /// </summary>
        E014 = 15,

        /// <summary>
        /// Process Guid alanı zorunludur.
        /// </summary>
        E029 = 30,

        /// <summary>
        /// Payzee uygulaması hata aldı.
        /// </summary>
        E090 = 91,

        /// <summary>
        /// okUrl zorunludur.
        /// </summary>
        E091 = 92,

        /// <summary>
        /// failUrl zorunludur.
        /// </summary>
        E092 = 93,
    }
}
