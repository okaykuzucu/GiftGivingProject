using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Yepp.App.Bussines.Securities
{
    /// <summary>
    /// Data Security
    /// </summary>
    /// <seealso cref="Yepp.App.Bussines.Securities.IDataSecurity" />
    public class DataSecurity : IDataSecurity
    {
        /// <summary>
        /// Deciryptions the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public async Task<string> Deciryption(string text)
        {
            string EncryptionKey = "";

            byte[] clearBytes = Encoding.Unicode.GetBytes(text);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    text =await Task.Run(()=> Convert.ToBase64String(ms.ToArray()));
                }
            }

            return text;
        }

        /// <summary>
        /// Encriyptions the specified text.
        /// </summary>
        /// <param name="cipherText"></param>
        /// <returns></returns>
        public async Task<string> Encriyption(string clearText)
        {
            string EncryptionKey = "";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return clearText;
        }
    }
}
