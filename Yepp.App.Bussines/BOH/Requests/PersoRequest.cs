using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Requests
{
    /// <summary>
    /// BOH/Document/ Perso Request
    /// </summary>
    public class PersoRequest
    {
        /// <summary>
        /// Gets or sets the wallet.
        /// </summary>
        /// <value>
        /// The wallet.
        /// </value>
        public object wallet { get; set; }

        /// <summary>
        /// Müşteri cüzdan Idsi
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public object customer { get; set; }

        /// <summary>
        /// Müşteri telefon numarası
        /// </summary>
        /// <value>
        /// The msisdn.
        /// </value>
        public string msisdn { get; set; }

        /// <summary>
        /// Cüzdan sahibi TCKN bilgisi
        /// </summary>
        /// <value>
        /// The TCKN.
        /// </value>
        public string tckn { get; set; }

        /// <summary>
        /// Cüzdan sahibinin adı
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Cüzdan sahibinin soyadı
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string surname { get; set; }

        /// <summary>
        /// Cüzdan sahibinin uyruğu. Türkiye uyruklu kişiler için "TR" girilmelidir. 
        /// Diğer ülke uyruklu kişiler için ISO 3166 listesine göre 2 haneli ülke kodu girilmelidir.
        /// </summary>
        /// <value>
        /// The nationality.
        /// </value>
        public string nationality { get; set; }

        /// <summary>
        /// Cüzdan sahibinin doğum tarihi
        /// </summary>
        /// <value>
        /// The birth date.
        /// </value>
        public string birthDate { get; set; }

        /// <summary>
        /// Cüzdan sahibinin doğum yeri
        /// </summary>
        /// <value>
        /// The birth place.
        /// </value>
        public string birthPlace { get; set; }

        /// <summary>
        /// Cüzdan sahibinin eposta adresi
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string email { get; set; }

        /// <summary>
        /// Cüzdan sahibi kurum Id
        /// </summary>
        /// <value>
        /// The supplier identifier.
        /// </value>
        public string supplierId { get; set; }
    }
}
