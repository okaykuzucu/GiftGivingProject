using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    /// <summary>
    /// BOH/Wallet/ Create Enum
    /// </summary>
    public enum CreateEnum
    {
        /// <summary>
        /// Kayıt oluşturulurken sistemsel hata aldı.
        /// </summary>
        E002 = 3,

        /// <summary>
        /// Telefon formatı hatalıdır (5XXXXXXXXX).
        /// </summary>
        E003 = 4,

        /// <summary>
        /// Cüzdan oluşturulurken dökümanlar zorunludur.
        /// </summary>
        E004 = 5,

        /// <summary>
        /// {0} dokümanı kabul edilmelidir.
        /// </summary>
        E005 = 6,

        /// <summary>
        /// Sistemimizde bu cep telefonuna bağlı cüzdan bulunmaktadır.
        /// </summary>
        E017 = 18,

        /// <summary>
        /// Telefon bilgisi zorunludur.
        /// </summary>
        E060 = 61,

        /// <summary>
        /// Girilen docId sistemimizde bulunamamıştır. Lütfen kontrol ederek tekrar giriniz.
        /// </summary>
        E061 = 62,

    }
}
