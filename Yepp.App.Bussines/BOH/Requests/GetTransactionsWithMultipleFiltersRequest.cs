namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Wallet/GetTransactionsWithMultipleFilters Request
    /// </summary>
    public class GetTransactionsWithMultipleFiltersRequest
    {
        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabının ID bilgisi
        /// </summary>
        /// <value>
        /// The wallet identifier.
        /// </value>
        public string walletId { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdan hesabına bağlı kartın ID bilgisi
        /// </summary>
        /// <value>
        /// The card identifier.
        /// </value>
        public string cardId { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için kullanılacak başlangıç tarihi bilgisidir.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public string startDate { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için kullanılacak bitiş tarihi bilgisidir.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public string endDate { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için paging yapısında kullanılacak sayfa bilgisidir. Default 0'dan başlamaktadır.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        public int page { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için paging yapısında kullanılacak sayfa başına düşen kayıt bilgisidir.
        /// </summary>
        /// <value>
        /// The limit.
        /// </value>
        public int limit { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için paging yapısında kullanılacak sıralama tipi bilgisidir. Alacağı değerler; A: Ascending , D: Descending . Gönderilmediğinde default D olarak gönderilir.
        /// </summary>
        /// <value>
        /// The type of the order.
        /// </value>
        public string orderType { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için kullanılacak işlem kaynağı bilgisidir. W: Cüzdan hareketleri, C: Kart hareketleri
        /// </summary>
        /// <value>
        /// The type of the transaction.
        /// </value>
        public string transactionType { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için kullanılacak işlem tipi bilgisidir. Aşağıdaki İşlem Tipleri ve Alt İşlem Tipleri tablosunda alınabilecek enum değerler gösterilmiştir. 0 girilirse tüm işlem tipleri gösterilir.
        /// </summary>
        /// <value>
        /// The type of the process.
        /// </value>
        public int processType { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için kullanılacak alt işlem tipi bilgisidir. Aşağıdaki İşlem Tipleri ve Alt İşlem Tipleri tablosunda alınabilecek enum değerler gösterilmiştir. 0 girilirse tüm alt işlem tipleri gösterilir.
        /// </summary>
        /// <value>
        /// The type of the process sub.
        /// </value>
        public int processSubType { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için kullanılacak işlem durumu bilgisidir. -1: Hepsi , 0: Pre , 1: Başarılı , 2: Bekleniyor , 3: Hatalı , 4: OTP Doğrulaması Bekleniyor
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public int status { get; set; }

        /// <summary>
        /// İlgili işlem(ler)i listelemek için kullanılacak döviz kuru. 949: Türk Lirası 840: Amerikan Doları 978: Euro
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        public int currencyCode { get; set; }
    }
}