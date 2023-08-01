using System.Threading.Tasks;

namespace Yepp.App.Bussines.Securities
{
    /// <summary>
    /// The Data Security 
    /// </summary>
    public interface IDataSecurity
    {
        /// <summary>
        /// Deciryptions the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        Task<string> Deciryption(string text);

        /// <summary>
        /// Encriyptions the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        Task<string> Encriyption(string cipherText);

    }
}
