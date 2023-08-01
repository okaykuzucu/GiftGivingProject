using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    public enum LoadWithVPOS3dEnum
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

        /// <summary>
        /// Kart numarası zorunludur.
        /// </summary>
        E093 = 94,

        /// <summary>
        /// CVV zorunludur.
        /// </summary>
        E094 = 95,

        /// <summary>
        /// Son kullanma tarihi yıl alanı zorunludur.
        /// </summary>
        E095 = 96,

        /// <summary>
        /// Son kullanma tarihi ay alanı zorunludur.
        /// </summary>
        E096 = 97,

        /// <summary>
        /// Kartın üzerindeki ad soyad zorunludur.
        /// </summary>
        E097 = 98,

        /// <summary>
        /// Kart kaydedilmek isteniyor ise karta isim vermek zorunludur.
        /// </summary>
        E098 = 99,

        /// <summary>
        /// Son kullanma tarihi yıl alanı YY formatında rakam olarak girilmelidir.
        /// </summary>
        E099 = 100,

        /// <summary>
        /// Son kullanma tarihi ay alanı AA formatında rakam olarak girilmelidir.
        /// </summary>
        E100 = 101,

        /// <summary>
        /// Kart numarası alanında sadece rakam girilmelidir.
        /// </summary>
        E101 = 102,

        /// <summary>
        /// Kart numarası maksimum 16 hane olarak girilmelidir.
        /// </summary>
        E102 = 103,

        /// <summary>
        /// CVV alanında sadece rakam girilmeli ve maksimum 4 hane olmalıdır.
        /// </summary>
        E103 = 104,
    }
}
