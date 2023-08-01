using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    /// <summary>
    /// BOH/Wallet/ Perso Enum
    /// </summary>
    public enum PersoEnum
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
        /// Cüzdan id'si zorunludur.
        /// </summary>
        E006 = 7,

        /// <summary>
        /// Request içerisindeki alanları doldurmak zorunludur.
        /// </summary>
        E007 = 8,

        /// <summary>
        /// TCKN bilgisi veya formatı hatalıdır. Lütfen doğru TCKN bilgisi giriniz.
        /// </summary>
        E008 = 9,

        /// <summary>
        /// İsim alanı zorunludur.
        /// </summary>
        E009 = 10,

        /// <summary>
        /// Soyisim alanı zorunludur.
        /// </summary>
        E010 = 11,

        /// <summary>
        /// Nationality alanı zorunludur.
        /// </summary>
        E011 = 12,

        /// <summary>
        /// Kullanıcı bilgilerinde hata vardır. Servis sağlayıcınız ile görüşünüz.
        /// </summary>
        E013 = 14,

        /// <summary>
        /// Cüzdan bilgisi bulunamadı.
        /// </summary>
        E014 = 15,

        /// <summary>
        /// Sistemimizde bu cep telefonuna bağlı cüzdan bulunmaktadır.
        /// </summary>
        E017 = 18,

        /// <summary>
        /// Sistemimizde girilen TCKN kaydı mevcuttur.
        /// </summary>
        E018 = 19,

        /// <summary>
        /// Kimlik bilgileri doğrulanamadı.
        /// </summary>
        E019 = 20,

        /// <summary>
        /// Doğum tarihi zorunludur.
        /// </summary>
        E020 = 21,

        /// <summary>
        /// Cüzdan kişiselleştirilmiş durumdadır.
        /// </summary>
        E021 = 22,

        /// <summary>
        /// Cüzdan durumu kişiselleştirme işlemi için uygun değildir.
        /// </summary>
        E022 = 23,

        /// <summary>
        /// Girdiğiniz telefon numarasıyla cüzdanınız eşleşmemektedir.
        /// </summary>
        E036 = 37,

        /// <summary>
        /// Telefon bilgisi zorunludur.
        /// </summary>
        E060 = 61,

        /// <summary>
        /// Email adresi formatı hatalıdır.
        /// </summary>
        E065 = 66,
    }
}
