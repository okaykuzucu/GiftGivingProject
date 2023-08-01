using System;
using System.Collections.Generic;
using System.Text;

namespace Yepp.App.Bussines.BOH.Responses
{
    public class BalanceTransactionInfoResponse
    {
        /// <summary>
        /// İşlemin başarılı olma durumu.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        public bool isSuccess { get; set; }

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
        /// İstek işleminin unique log Id bilgisi.
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
        /// Bakiye yükleme işlem tutarı bilgisidir.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public int amount { get; set; }

        /// <summary>
        /// Müşteri cüzdan Idsi
        /// </summary>
        /// <value>
        /// The wallet number.
        /// </value>
        public string walletNumber { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait bakiyelerin döviz kuru. 949: Türk Lirası 840: Amerikan Doları 978: Euro
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        public int currencyCode { get; set; }

        /// <summary>
        /// Son kullanıcı için oluşturulan cüzdana ait bakiyelerin döviz kuru açıklaması. TRY: Türk Lirası USD: Amerikan Doları EUR: Euro
        /// </summary>
        /// <value>
        /// The currency code desc.
        /// </value>
        public string currencyCodeDesc { get; set; }

        /// <summary>
        /// Benzersiz (unique) işlem kaydı bilgisidir.
        /// </summary>
        /// <value>
        /// The process GUID.
        /// </value>
        public string processGuid { get; set; }

        /// <summary>
        /// Bakiye yükleme işlem numarası bilgisidir. İş ortaklarımızın kendi taraflarındaki oluşturulacak işlemin unique (benzersiz) olduğunu ifade eder.
        /// </summary>
        /// <value>
        /// The order no.
        /// </value>
        public string orderNo { get; set; }

        /// <summary>
        /// Benzersiz (unique) işlem referans kodu bilgisidir.
        /// </summary>
        /// <value>
        /// The reference code.
        /// </value>
        public string referenceCode { get; set; }

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
        /// İşlemin statü neden kodu bilgisidir.
        /// </summary>
        /// <value>
        /// The status reason.
        /// </value>
        public string statusReason { get; set; }

        /// <summary>
        /// Bakiye yükleme işlem açıklamasıdır. İş ortaklarımızın müşterilerinin işlem anındaki açıklama bilgisinin gönderilmesini sağlar.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string description { get; set; }

        /// <summary>
        /// İş ortaklarımızın komisyon bilgilendirmesinden sonra müşterilerine gösterdiği yükleme tutar bilgisidir.
        /// </summary>
        /// <value>
        /// The load amount.
        /// </value>
        public int loadAmount { get; set; }

        /// <summary>
        /// Son kullanıcıya yansıtılan komisyon tutarı bilgisidir.
        /// </summary>
        /// <value>
        /// The customer commission amount.
        /// </value>
        public int customerCommissionAmount { get; set; }

        /// <summary>
        /// Partner kuruma yansıtılan komisyon tutarı bilgisidir.
        /// </summary>
        /// <value>
        /// The partner commission amount.
        /// </value>
        public int partnerCommissionAmount { get; set; }

        /// <summary>
        /// İlgili işleme ait işlem tarihi bilgisidir.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public string createdDate { get; set; }

        /// <summary>
        /// İlgili işleme ait son güncellenme tarihi bilgisidir.
        /// </summary>
        /// <value>
        /// The updated date.
        /// </value>
        public string updatedDate { get; set; }

        /// <summary>
        /// İlgili işlem tipi bilgisidir. 1:Para Yükleme 2:Para Transferi 3:Ödeme 4:Para Çekme
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public int type { get; set; }

        /// <summary>
        /// İlgili işlem tipinin açıklama bilgisidir. type alanındaki değerin açıklamasıdır.
        /// </summary>
        /// <value>
        /// The type desc.
        /// </value>
        public string typeDesc { get; set; }

        /// <summary>
        /// İş ortaklarımızın GetBank servisinden işleme devam edeceği bankaların IBAN bilgisidir.
        /// </summary>
        /// <value>
        /// The intermediate iban.
        /// </value>
        public string intermediateIBAN { get; set; }

        /// <summary>
        /// İlgili işlemi gerçekleştiren gönderici telefon numarası bilgisidir.
        /// </summary>
        /// <value>
        /// The sender msisdn.
        /// </value>
        public string senderMSISDN { get; set; }

        /// <summary>
        /// İlgili işlem için gönderici IBAN bilgisidir.
        /// </summary>
        /// <value>
        /// The sender iban.
        /// </value>
        public string senderIBAN { get; set; }

        /// <summary>
        /// İlgili işlem için alıcı IBAN bilgisidir.
        /// </summary>
        /// <value>
        /// The receiver iban.
        /// </value>
        public string receiverIBAN { get; set; }


    }
}
