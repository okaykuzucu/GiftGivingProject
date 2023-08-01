using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Yepp.App.Services;
using Yepp.App.Services.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Yepp.App.WebServices.Models.Requests;
using Yepp.App.WebServices.Dtos;


namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    ///PaymesController
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PaymesController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IHttpClientFactory _mandrillClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymesController" /> class.
        /// </summary>
        /// <param name="eventService">The event service.</param>
        /// <param name="mandrillClient">The mandrill client.</param>
        public PaymesController(
            IEventService eventService,
            IHttpClientFactory mandrillClient)
        {
            _eventService = eventService;
            _mandrillClient = mandrillClient;
        }

        /// <summary>
        /// Pays this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Pay(PaymesDto paymesDto)
        {
            if(paymesDto.EventId == null)
            {
                return new ObjectResult("EventId is not null") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest };
            }

            var _event = await _eventService.GetDetail(new Guid(paymesDto.EventId));

            paymesDto.secret = "";
            paymesDto.installmentsNumber = "1";
            paymesDto.owner = paymesDto.billingFirstname + " " + paymesDto.billingLastname;
            paymesDto.productQuantity = "1";

            /* TO-DO testler bittikten sonra canlıya cıkarken bu satır işletilecek
             */
            paymesDto.productPrice = Convert.ToString(_event.TotalBalance).Replace(',','.');

            //paymesDto.productPrice = "0.1";

            paymesDto.currency = "";
            paymesDto.deliveryFirstname = "";
            paymesDto.deliveryLastname = "";

            var dict = new Dictionary<string, string>();
            dict.Add("secret", paymesDto.secret);
            dict.Add("number", paymesDto.number);
            dict.Add("installmentsNumber", paymesDto.installmentsNumber);
            dict.Add("expiryMonth", paymesDto.expiryMonth);
            dict.Add("expiryYear", paymesDto.expiryYear);
            dict.Add("cvv", paymesDto.cvv);
            dict.Add("owner", paymesDto.owner);
            dict.Add("billingFirstname", paymesDto.billingFirstname);
            dict.Add("billingLastname", paymesDto.billingLastname);
            dict.Add("billingEmail", paymesDto.billingEmail);
            dict.Add("clientIp", paymesDto.clientIp);
            dict.Add("productName", paymesDto.productName);
            dict.Add("productQuantity", paymesDto.productQuantity);
            dict.Add("productPrice", paymesDto.productPrice);
            dict.Add("currency", paymesDto.currency);
            dict.Add("deliveryFirstname", paymesDto.deliveryFirstname);
            dict.Add("deliveryLastname", paymesDto.deliveryLastname);
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://web.paym.es/api/authorize") { Content = new FormUrlEncodedContent(dict) };
            var response = await client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                return
                     new ObjectResult("Ödeme alınamadı...") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound };
            }

            var paymesApiStringResult = response.Content.ReadAsStringAsync().Result;
            dynamic paymesApijsonResult = JsonConvert.DeserializeObject(paymesApiStringResult);
            string payuPaymentReference = paymesApijsonResult.payuPaymentReference;

            var eventUpdateOptions = new EventUpdateOptions();
            eventUpdateOptions.UserId = _event.UserId;
            eventUpdateOptions.CategoryId = _event.CategoryId;
            eventUpdateOptions.Title = _event.Title;
            eventUpdateOptions.Description = _event.Description;
            eventUpdateOptions.Image = _event.Image;
            eventUpdateOptions.TotalBalance = _event.TotalBalance;
            eventUpdateOptions.EndDate = _event.EndDate;
            eventUpdateOptions.StatusId = _event.StatusId;
            eventUpdateOptions.payuPaymentReference = payuPaymentReference;

            var _result = await _eventService.UpdateByIdAsync(_event.Id,
               eventUpdateOptions
                );

            //string status = paymesApijsonResult.status;
            string code = paymesApijsonResult.code;
            if(code != "200")
            {
                return
                     new ObjectResult("Ödeme alınamadı...") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound };
            }

            var data = new PaymesInfoEmailInformationRequest();
            data.Email = paymesDto.billingEmail;
            data.Language = "tr-Tr";
            data.Name = paymesDto.deliveryFirstname + " " + paymesDto.deliveryLastname; 
            data.Order = _event.Title + "'na " + _event.TotalBalance;



            var requestmail = new HttpRequestMessage(HttpMethod.Post, "api/YeppEmailService/PaymesInfoEmailInformation");

            //var requestmail = new HttpRequestMessage(HttpMethod.Post, "http://localhost:64522/api/YeppEmailService/PaymesInfoEmailInformation");
            string json = System.Text.Json.JsonSerializer.Serialize(data);
            requestmail.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = _mandrillClient.CreateClient("yepp-mandrill-api");
            var responsemail = await httpClient.SendAsync(requestmail);




            if (!responsemail.IsSuccessStatusCode)
            {
                return NotFound();
            }



            /* TO-DO 
             * teşekkür maili gönderilicek.
             * "{_event.title}'na {_event.TotalBalance} TL değerinde katkı sağladığınız için teşekkür ederiz"
             * "Ayşe'nin Dilek Kutusu'na 500 TL değerinde katkı sağladığınız için teşekkür ederiz"
            */

            return
                new ObjectResult(paymesApiStringResult) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }

        /// <summary>
        /// Pays the status.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PayStatus(string payuPaymentReference)
        {

            var dict = new Dictionary<string, string>();
            dict.Add("paymentReference", payuPaymentReference);

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://web.paym.es/api/status") { Content = new FormUrlEncodedContent(dict) };
            var response = await client.SendAsync(request);

            var paymesApiStringResult = await response.Content.ReadAsStringAsync();
            dynamic paymesApijsonResult = JsonConvert.DeserializeObject(paymesApiStringResult);
            string status = paymesApijsonResult.status;

            if (!response.IsSuccessStatusCode)
            {
                return
                     new ObjectResult("Ödeme durumu alınamadı...") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound };
            }

            return
                new ObjectResult(response.Content.ReadAsStringAsync().Result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }
    }
}

/*
    Kullanıcı Paneli: https://kullanici.paym.es
    Kullanıcı Adı: yepp.app
    Şifre: 6f22f2

    API Public Key: 800d033f-f548-448f-b01c-faf9d7987765
    API Secret Key: d244e340c468349cc4c2bd3fb1279a42

    Dokümantasyon Linki: https://paymes-api.gitbook.io/paymes-api-v3/
 */