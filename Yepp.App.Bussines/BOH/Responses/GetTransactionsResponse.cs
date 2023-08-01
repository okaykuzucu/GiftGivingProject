using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    /// <summary>
    /// BOH/Wallet/GetTransactions Response
    /// </summary>
    public class GetTransactionsResponse
    {
        /// <summary>
        /// İşlemin başarılı olma durumu
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        public bool isSuccess { get; set; }

        /// <summary>
        /// 	İşlem hata kodu
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public string errorCode { get; set; }

        /// <summary>
        /// 	İşlem sonuç mesajı
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string message { get; set; }

        /// <summary>
        ///İstek işleminin unique log Id bilgisi
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
        /// Sayfalama yapısına göre ilgili işlem listesinin sayfa numarası bilgisidir.
        /// </summary>
        /// <value>
        /// The current page.
        /// </value>
        public object currentPage { get; set; }

        /// <summary>
        /// Sayfalama yapısına göre ilgili işlem listesinin kayıt sayısı bilgisidir.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public object size { get; set; }

        /// <summary>
        /// Sayfalama yapısına göre ilgili sayfadan sonra sayfa gelip gelmediği bilgisidir. true: sonraki sayfa var . false: sonraki sayfa yok
        /// </summary>
        /// <value>
        /// The has next page.
        /// </value>
        public bool hasNextPage { get; set; }

        /// <summary>
        /// Sayfalama yapısına göre ilgili işlem listesinin toplam sayfa sayısı bilgisidir.
        /// </summary>
        /// <value>
        /// The total page.
        /// </value>
        public int totalPage { get; set; }

        /// <summary>
        /// Sayfalama yapısına göre ilgili işlem listesinin toplam kayıt sayısı bilgisidir.
        /// </summary>
        /// <value>
        /// The total count.
        /// </value>
        public int totalCount { get; set; }

        /// <summary>
        /// Gets or sets the transactions.
        /// </summary>
        /// <value>
        /// The transactions.
        /// </value>
        public object transactions { get; set; }

        /// <summary>
        /// Benzersiz (unique) işlem kaydı bilgisidir.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string id { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının ID bilgisidir. İşlemi yapan cüzdandır.
        /// </summary>
        /// <value>
        /// The wallet identifier.
        /// </value>
        public string walletId { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının ID bilgisidir. Orijinal işlemden etkilenen cüzdandır.
        /// </summary>
        /// <value>
        /// To wallet identifier.
        /// </value>
        public string toWalletId { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabına bağlı kartın ID bilgisi
        /// </summary>
        /// <value>
        /// The card identifier.
        /// </value>
        public string cardId { get; set; }

        /// <summary>
        /// İlgili işleme ait tutar bilgisidir.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public int amount { get; set; }

        /// <summary>
        /// İlgili işleme ait döviz kuru. 949: Türk Lirası 840: Amerikan Doları 978: Euro
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        public int currencyCode { get; set; }

        /// <summary>
        /// İlgili işleme ait işlem tipi bilgisidir.
        /// </summary>
        /// <value>
        /// The type of the process.
        /// </value>
        public int processType { get; set; }

        /// <summary>
        /// İlgili işleme ait işlem tipinin açıklama bilgisidir.
        /// </summary>
        /// <value>
        /// The process type desc.
        /// </value>
        public string processTypeDesc { get; set; }

        /// <summary>
        ///İlgili işleme ait alt işlem tipi bilgisidir.
        /// </summary>
        /// <value>
        /// The type of the process sub.
        /// </value>
        public int processSubType { get; set; }

        /// <summary>
        /// İlgili işleme ait alt işlem tipinin açıklama bilgisidir.
        /// </summary>
        /// <value>
        /// The process sub type desc.
        /// </value>
        public string processSubTypeDesc { get; set; }

        /// <summary>
        ///İlgili işleme ait işlem tarihi bilgisidir.
        /// </summary>
        /// <value>
        /// The transaction date.
        /// </value>
        public string transactionDate { get; set; }

        /// <summary>
        /// İlgili işleme ait son güncellenme tarihi bilgisidir.
        /// </summary>
        /// <value>
        /// The last update date.
        /// </value>
        public string lastUpdateDate { get; set; }

        /// <summary>
        /// İşlemin statü kodu bilgisidir. 0: Pre 1: Success 2: Pending 3: Failure 4: VerifyOtpPending
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public int status { get; set; }

        /// <summary>
        /// İşlemin statü açıklaması bilgisidir.
        /// </summary>
        /// <value>
        /// The status desc.
        /// </value>
        public string statusDesc { get; set; }

        /// <summary>
        /// İşlemin borç/alacak kaydı bilgisidir. Para çıkışlarında Borç (Debit), para girişlerinde Alacak (Credit) gönderilir.
        /// </summary>
        /// <value>
        /// The debit credit desc.
        /// </value>
        public string debitCreditDesc { get; set; }

        /// <summary>
        /// İşlemin borç/alacak kaydı belirtecidir. 1: Alacak, 2:Borç
        /// </summary>
        /// <value>
        /// The debit credit flag.
        /// </value>
        public int debitCreditFlag { get; set; }

        /// <summary>
        /// İşlem eğer ödeme işlemiyse, işlem yapılan işyeri kategori numarası (merchant category code) bilgisidir.
        /// </summary>
        /// <value>
        /// The MCC.
        /// </value>
        public string mcc { get; set; }

        /// <summary>
        /// İşlem eğer ödeme işlemiyse, işlem yapılan işyeri kategori numarası açıklama bilgisidir.
        /// </summary>
        /// <value>
        /// The MCC description.
        /// </value>
        public string mccDescription { get; set; }

        /// <summary>
        /// İşlem eğer ödeme işlemiyse, işlem yapılan işyeri isim bilgisidir.
        /// </summary>
        /// <value>
        /// The name of the merchant.
        /// </value>
        public string merchantName { get; set; }

        /// <summary>
        /// İşlem eğer ödeme işlemiyse, işlem yapılan işyeri pos bankasının EFT kodu bilgisidir.
        /// </summary>
        /// <value>
        /// The acquirer bin.
        /// </value>
        public string acquirerBIN { get; set; }

        /// <summary>
        /// İşlem eğer ödeme işlemiyse, işlem yapılan işyeri pos bankasının ticari isim bilgisidir.
        /// </summary>
        /// <value>
        /// The name of the acquirer.
        /// </value>
        public string acquirerName { get; set; }

        /// <summary>
        /// İşlem eğer bakiye transferi veya fatura ödeme işlemiyse, tutarın gönderildiği kişi/kurum bilgisidir. Cüzdan sahibi kendi hesabına veya kartına transfer işlemi yaparsa cüzdan sahibinin ismi bu alanda görünür. Başka cüzdana transfer işlemi yaptıysa alıcı cüzdan sahibinin ismi görünür.
        /// </summary>
        /// <value>
        /// The name of the receiver.
        /// </value>
        public string receiverName { get; set; }

        /// <summary>
        /// İşlemin gerçekleştiği kanal ID bilgisidir.
        /// </summary>
        /// <value>
        /// The channel identifier.
        /// </value>
        public string channelId { get; set; }

        /// <summary>
        /// İşlemin gerçekleştiği kanal adı bilgisidir.
        /// </summary>
        /// <value>
        /// The name of the channel.
        /// </value>
        public string channelName { get; set; }
    }
}