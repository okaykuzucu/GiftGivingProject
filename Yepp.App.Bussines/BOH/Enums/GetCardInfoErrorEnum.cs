namespace Yepp.App.Bussines.BOH.Enums
{
    /// <summary>
    ///BOH/Wallet/GetCardInfo Error Enum
    /// </summary>
    public enum GetCardInfoErrorEnum
    {
        /// <summary>
        /// Kayıt bulunamadı.
        /// </summary>
        E000 = 1,

        /// <summary>
        /// 	İlgili işlem için kart statüsü uygun değil.
        /// </summary>
        E077 = 2,

        /// <summary>
        /// Kart id zorunlu.
        /// </summary>
        E078 = 3,

        /// <summary>
        /// Kart entegrasyon hatası alındı.
        /// </summary>
        E080 = 4
    }
}