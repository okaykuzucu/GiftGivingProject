namespace Yepp.App.Bussines.BOH.Enums
{
    /// <summary>
    /// BOH/Wallet/GetTransactions Error Enum
    /// </summary>
    public enum GetTransactionsErrorEnum
    {
        /// <summary>
        ///Kayıt bulunamadı.
        /// </summary>
        E000 = 1,

        /// <summary>
        /// Cüzdan id'si zorunludur.
        /// </summary>
        E006 = 2,

        /// <summary>
        /// Cüzdan bilgisi bulunamadı.
        /// </summary>
        E014 = 3,

        /// <summary>
        /// Başlangıç ve bitiş tarih aralığı 30 günden fazla olamaz.
        /// </summary>
        E066 = 4
    }
}