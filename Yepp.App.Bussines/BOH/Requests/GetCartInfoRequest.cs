namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    ///BOH/Wallet/GetCardInfo Request
    /// </summary>
    public class GetCartInfoRequest
    {
        /// <summary>
        ///Son kullanıcı için oluşturulan cüzdana bağlı sanal kart ID bilgisi
        /// </summary>
        /// <value>
        /// The card ids.
        /// </value>
        public int cardIds { get; set; }
    }
}