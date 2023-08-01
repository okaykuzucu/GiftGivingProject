using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH//WALLET//WalletBalanceByMSISDN Response
    /// </summary>
    public class WalletBalanceByMSISDNResponse
    {
        /// <summary>
        /// İşlemin başarılı olma durumu
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is succes; otherwise, <c>false</c>.
        /// </value>
        public bool isSucces { get; set; }

        /// <summary>
        /// İşlem hata kodu
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public string errorCode { get; set; }

        /// <summary>
        /// İşlem sonuç mesajı
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string message { get; set; }

        /// <summary>
        /// İstek işleminin unique log Id bilgisi
        /// </summary>
        /// <value>
        /// The request identifier.
        /// </value>
        public string requestId { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object data { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait bakiyelerin döviz kuru. 
        /// 949: Türk Lirası 840: Amerikan Doları 978: Euro
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        public int currencyCode { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait bakiyelerin döviz kuru açıklaması. 
        /// TRY: Türk Lirası USD: Amerikan Doları EUR: Euro
        /// </summary>
        /// <value>
        /// The currency code desc.
        /// </value>
        public string currencyCodeDesc { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait güncel toplam (topUpAmount + accountAmount) bakiye bilgisi
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public int amount { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait güncel topUp bakiye bilgisi.
        /// Kredi kartından veya Masterpass'ten bakiye yükleme işlemlerinde bu değer baz alınmalıdır.
        /// </summary>
        /// <value>
        /// The top up amount.
        /// </value>
        public int topUpAmount { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait güncel hesap bakiye bilgisi. 
        /// Hesaptan bakiye yükleme işlemlerinde bu değer baz alınmalıdır.
        /// </summary>
        /// <value>
        /// The account amount.
        /// </value>
        public int accountAmount { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının aktiflik bilgisi.
        /// 0: Pasif 1: Aktif 2: Freeze 4: Geçici Kapalı 5: ZorunluDokumanOnayı .
        /// </summary>
        /// <value>
        /// The wallet status.
        /// </value>
        public string walletStatus { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının aktiflik bilgisi.
        /// 0: Pasif 1: Aktif 2: Freeze 4: Geçici Kapalı 5: ZorunluDokumanOnayı .
        /// </summary>
        /// <value>
        /// The type of the wallet status.
        /// </value>
        public int walletStatusType { get; set; }
    }
}
