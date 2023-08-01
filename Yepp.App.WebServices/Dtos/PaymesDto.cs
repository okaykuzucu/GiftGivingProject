
namespace Yepp.App.WebServices.Dtos
{
    public class PaymesDto
    {
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets the secret. (api-key)
        /// </summary>
        /// <value>
        /// The secret.
        /// </value>
        public string? secret { get; set; }

        /// <summary>
        /// Gets or sets the number. (Kredi kartı numarası(Boşluksuz yazılmalı.)
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public string number { get; set; }

        /// <summary>
        /// Gets or sets the installments number. 1 (Yalnızca “1” yazılmalı.)
        /// </summary>
        /// <value>
        /// The installments number.
        /// </value>
        public string? installmentsNumber { get; set; }

        /// <summary>
        /// Gets or sets the expiry Month. (Sayı olarak kredi kartı son kullanım ayı (01 – 12 arası olmalı.))
        /// </summary>
        /// <value>
        /// The expiry date.
        /// </value>
        public string expiryMonth { get; set; }

        /// <summary>
        /// Gets or sets the expiry year. (Sayı olarak kredi kartı son kullanım yılının son 2 hanesi(Örnek: 20))
        /// </summary>
        /// <value>
        /// The expiry year.
        /// </value>
        public string expiryYear { get; set; }

        /// <summary>
        /// Gets or sets the CVV. (Kredi kartının arkasındaki 3 haneli sayı)
        /// </summary>
        /// <value>
        /// The CVV.
        /// </value>
        public string cvv { get; set; }

        /// <summary>
        /// Gets or sets the owner. (Kredi kartının sahibinin adı ve soyadı)
        /// </summary>
        /// <value>
        /// The owner.
        /// </value>
        public string? owner { get; set; }

        /// <summary>
        /// Gets or sets the billing firstname. (Faturanın kesileceği kişinin adı)
        /// </summary>
        /// <value>
        /// The billing firstname.
        /// </value>
        public string billingFirstname { get; set; }

        /// <summary>
        /// Gets or sets the billing lastname. (Faturanın kesileceği kişinin soyadı)
        /// </summary>
        /// <value>
        /// The billing lastname.
        /// </value>
        public string billingLastname { get; set; }

        /// <summary>
        /// Gets or sets the billingLastname. (Fatura için e-posta adresi)
        /// </summary>
        /// <value>
        /// The billing email.
        /// </value>
        public string billingEmail { get; set; }

        /// <summary>
        /// Gets or sets the clientIp. (Alıcının IP adresi)
        /// </summary>
        /// <value>
        /// The billing phone.
        /// </value>
        public string clientIp { get; set; }

        /// <summary>
        /// Gets or sets the productName. (Ürünün adı)
        /// </summary>
        /// <value>
        /// The billing countrycode.
        /// </value>
        public string productName { get; set; }

        /// <summary>
        /// Gets or sets the productQuantity. (Ürün adedi)
        /// </summary>
        /// <value>
        /// The billing addressline1.
        /// </value>
        public string? productQuantity { get; set; }

        /// <summary>
        /// Gets or sets the productPrice. (Ürün fiyatı)
        /// </summary>
        /// <value>
        /// The billing city.
        /// </value>
        public string? productPrice { get; set; }

        /// <summary>
        /// Gets or sets the currency. (Fiyatın para birimi (TRY, USD, EUR). Gönderilmediği taktirde otomatik olarak TRY kabul eder)
        /// </summary>
        /// <value>
        /// The delivery lastname.
        /// </value>
        public string? currency { get; set; }

        /// <summary>
        /// Gets or sets the deliveryFirstname. (Kargo alıcısının adı)
        /// </summary>
        /// <value>
        /// The delivery phone.
        /// </value>
        public string? deliveryFirstname { get; set; }

        /// <summary>
        /// Gets or sets the deliveryLastname. (Kargo alıcısının soyadı)
        /// </summary>
        /// <value>
        /// The delivery addressline1.
        /// </value>
        public string? deliveryLastname { get; set; }
    }
}
