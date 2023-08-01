namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Auth/ Login Request
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Bearer token almak için kullanılacak şifreniz
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string email { get; set; }

        /// <summary>
        /// Bearer token almak için kullanılacak şifreniz
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string password { get; set; }

        /// <summary>
        /// Dil seçimi. Türkçe için TR, İngilizce için EN girilmesi gerekmektedir. Girilmediğinde, varsayılan (default) olarak TR olur.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        public string language { get; set; }
    }
}