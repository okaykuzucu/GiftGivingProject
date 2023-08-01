namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Wallet/CreateCardForWallet Request
    /// </summary>
    public class CreateCardForWalletRequest
    {
        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının ID bilgisi
        /// </summary>
        /// <value>
        /// The wallet identifier.
        /// </value>
        public string walletId { get; set; }

        /// <summary>
        /// 	Son kullanıcı için oluşturulan sanal kart için kullanıcının tanımlayabileceği açıklama bilgisi
        /// </summary>
        /// <value>
        /// The decsription.
        /// </value>
        public string decsription { get; set; }
    }
}