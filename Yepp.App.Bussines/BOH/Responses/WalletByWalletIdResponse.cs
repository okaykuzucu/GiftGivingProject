using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH/Wallet/WalletByWalletId Response
    /// </summary>
    public class WalletByWalletIdResponse
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
        /// Son kullanıcı için oluşturulan cüzdan hesabının ID bilgisi
        /// </summary>
        /// <value>
        /// The wallet identifier.
        /// </value>
        public string walletId { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public object customer { get; set; }

        /// <summary>
        /// Cüzdan sahibi son kullanıcı ad bilgisi
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Cüzdan sahibi son kullanıcı soyad bilgisi
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string surname { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının oluşturulma tarihi
        /// </summary>
        /// <value>
        /// The name of the created.
        /// </value>
        public string createdName { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının kişiselleştirilme tarihi
        /// </summary>
        /// <value>
        /// The perso date.
        /// </value>
        public string persoDate { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının kişiselleştirilme durumu. 
        /// U: Unregistered (Kişiselleştirilmemiş) P: Registered (Kişiselleştirilmiş)
        /// </summary>
        /// <value>
        /// The perso flag.
        /// </value>
        public string persoFlag { get; set; }

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

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının son durum tarihi bilgisi
        /// </summary>
        /// <value>
        /// The last status date.
        /// </value>
        public string lastStatusDate { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının müşteri segmenti. 
        /// B: Bireysel K: Kurumsal
        /// </summary>
        /// <value>
        /// The customer segment.
        /// </value>
        public string customerSegment { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının tipi. 
        /// Standart: Kişiselleştirilmemiş Premium: Kişiselleştirilmiş
        /// </summary>
        /// <value>
        /// The type of the account.
        /// </value>
        public string accountType { get; set; }

        /// <summary>
        /// Gets or sets the balances.
        /// </summary>
        /// <value>
        /// The balances.
        /// </value>
        public object balances { get; set; }

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
        public int currencyCodeDesc { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait güncel toplam (topUpAmount + accountAmount) bakiye bilgisi
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public int amount { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait güncel topUp bakiye bilgisi. Kredi kartından veya Masterpass'ten bakiye yükleme işlemlerinde bu değer baz alınmalıdır.
        /// </summary>
        /// <value>
        /// The top up ammount.
        /// </value>
        public int topUpAmmount { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait güncel hesap bakiye bilgisi. 
        /// Hesaptan bakiye yükleme işlemlerinde bu değer baz alınmalıdır.
        /// </summary>
        /// <value>
        /// The account ammount.
        /// </value>
        public int accountAmmount { get; set; }

        /// <summary>
        /// Gets or sets the limits.
        /// </summary>
        /// <value>
        /// The limits.
        /// </value>
        public object limits { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait tanımlanan limitlerin işlem tipi bilgisi. 
        /// Alabileceği değerler: Para Yükleme, Para Transferi, Ödeme, Para Çekme
        /// </summary>
        /// <value>
        /// The type of the limit group.
        /// </value>
        public string limitGroupType { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait tanımlanan limitlerin işlem tipi ID bilgisi. 
        /// Alabileceği değerler: 1 (Para Yükleme), 2 (Para Transferi), 3 (Ödeme), 4 (Para Çekme)
        /// </summary>
        /// <value>
        /// The limit group type key.
        /// </value>
        public int limitGroupTypeKey { get; set; }

        /// <summary>
        /// Gets or sets the remaining limits.
        /// </summary>
        /// <value>
        /// The remaining limits.
        /// </value>
        public object remainingLimits { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait kalan limitlerin limit tipi bilgisi. 
        /// Alabileceği değerler: Anlık Limit, Günlük Limit, Haftalık Limit, Aylık Limit, Yıllık Limit
        /// </summary>
        /// <value>
        /// The type of the limit.
        /// </value>
        public string limitType { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait kalan limitlerin limit tipi ID bilgisi. 
        /// Alabileceği değerler: 1 (Anlık Limit), 2 (Günlük Limit), 3 (Haftalık Limit), 4 (Aylık Limi), 5 (Yıllık Limit)
        /// </summary>
        /// <value>
        /// The limit type key.
        /// </value>
        public int limitTypeKey { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait limit tipi için kalan limit tutarı bigisi
        /// </summary>
        /// <value>
        /// The remaning limit.
        /// </value>
        public int remaningLimit { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait tanımlı limit tipi için limit tutarı bigisi
        /// </summary>
        /// <value>
        /// The default limits.
        /// </value>
        public object defaultLimits { get; set; }

        /// <summary>
        /// createCardFlag=true olması durumunda kart bilgileri gelir.
        /// </summary>
        /// <value>
        /// The cards.
        /// </value>
        public object cards { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın maskeli PAN bilgisi
        /// </summary>
        /// <value>
        /// The masked pan.
        /// </value>
        public string maskedPan { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın id bilgisi
        /// </summary>
        /// <value>
        /// The cardid.
        /// </value>
        public int cardid { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın son kullanma tarihi bilgisi
        /// </summary>
        /// <value>
        /// The expiry date.
        /// </value>
        public string expiryDate { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın cvv (güvenlik kodu) bilgisi
        /// </summary>
        /// <value>
        /// The CVV.
        /// </value>
        public int cvv { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın kart adı bilgisi
        /// </summary>
        /// <value>
        /// The name of the card.
        /// </value>
        public int cardName { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın kart tipi bilgisi.
        /// </summary>
        /// <value>
        /// The type of the card.
        /// </value>
        public int cardType { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın kart tipi açıklaması bilgisi.
        /// </summary>
        /// <value>
        /// The card type desc.
        /// </value>
        public string cardTypeDesc { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın statü kodu bilgisidir. 
        /// 0: Pre 1: Success 2: Pending 3: Failure 4: VerifyOtpPending
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public int status { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın statü açıklaması bilgisi
        /// </summary>
        /// <value>
        /// The status desc.
        /// </value>
        public string statusDesc { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal kartın statü neden kodu bilgisi
        /// </summary>
        /// <value>
        /// The status reason.
        /// </value>
        public string statusReason { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan sanal karta ait oluşturulma tarihi bilgisi
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public string createdDate { get; set; }
    }
}
