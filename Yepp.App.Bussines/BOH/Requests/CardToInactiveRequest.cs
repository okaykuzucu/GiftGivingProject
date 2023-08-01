namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Wallet/CardToInactive Request
    /// </summary>
    public class CardToInactiveRequest
    {
        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana bağlı sanal kart ID bilgisi
        /// </summary>
        /// <value>
        /// The card identifier.
        /// </value>
        public int cardId { get; set; }
    }
}