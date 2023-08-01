using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Enums
{
    /// <summary>
    /// BOH/Wallet/WalletByMSISDN Enum
    /// </summary>
    public enum WalletByMSISDNEnum
    {
        /// <summary>
        /// Kayıt bulunamadı.
        /// </summary>
        E00 = 1,

        /// <summary>
        /// Telefon formatı hatalıdır (5XXXXXXXXX).
        /// </summary>
        E003 = 4,

        /// <summary>
        /// Kullanıcı bilgilerinde hata vardır. Servis sağlayıcınız ile görüşünüz.
        /// </summary>
        E013 = 14,
    }
}
