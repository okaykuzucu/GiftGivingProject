using EasyHttp.Http;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using System.Threading.Tasks;
using Yepp.App.Mandrill.Services.Models;
using Yepp.App.Mandrill.Services.Models.Enums;

namespace Yepp.App.Mandrill.Services.Services
{
    public static class MandrillService
    {
        private static MandrillResult _mandrillResult;
        private static readonly string MandrillBaseUrl = "http://mandrillapp.com/api/1.0";

        private static string emailFrom = "";
        private static string emailFromName = "";

        public static async Task<MandrillResult> UserVerification(string userId, string userName, string userLastName, string language, string userEmail)
        {
            _mandrillResult = new MandrillResult();
            dynamic sendParams = new ExpandoObject();
            sendParams.message = new ExpandoObject();
            sendParams.key = "";

            if (language == "tr")
            {
                sendParams.template_name = "verification_tr";
                sendParams.message.subject = "Yepp.app Kullanıcı Onay";
            }
            if (language == "en")
            {
                sendParams.template_name = "verification_en";
                sendParams.message.subject = "Yepp.app User Verification";

            }
            sendParams.template_content = new List<dynamic>();


            sendParams.message.from_email = emailFrom;
            sendParams.message.from_name = emailFromName;

            sendParams.message.to = new List<dynamic>();
            sendParams.message.to.Add(new ExpandoObject());
            sendParams.message.to[0].email = userEmail;
            sendParams.message.to[0].name = userName + " " + userLastName;

            sendParams.message.track_opens = true;
            //sendParams.message.track_clicks = true;

            sendParams.message.global_merge_vars = new List<dynamic>();
            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[0].name = "USER_NAME";
            sendParams.message.global_merge_vars[0].content = userName;

            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[1].name = "USER_LAST_NAME";
            sendParams.message.global_merge_vars[1].content = userLastName;

            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[2].name = "USER_ID";
            sendParams.message.global_merge_vars[2].content = userId;

            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[3].name = "USER_EMAIL";
            sendParams.message.global_merge_vars[3].content = userEmail;

            MandrillError merr = SendMessage(sendParams);

            switch (merr)
            {
                case MandrillError.OK:
                    _mandrillResult.IsOk = true;
                    _mandrillResult.Message = "An activation link has been sent to your email address.";
                    break;
                case MandrillError.WebException:
                    _mandrillResult.Message = "An error occurred while sending the email";
                    _mandrillResult.IsOk = false;
                    break;
                case MandrillError.HttpNotOk:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an issue sending your activation e-mail. Please try again later or call us directly.";
                    break;
                case MandrillError.Invalid:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your email address appears to be invalid. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Rejected:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your activation email was rejected. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Unknown:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an unknown problem sending your activation email. Please try again, or call us directly.";
                    break;
            }
            return _mandrillResult;
        }

        public static async Task<MandrillResult> UserCongratulation(string userEmail, string language, string userName)
        {
            _mandrillResult = new MandrillResult();
            dynamic sendParams = new ExpandoObject();
            sendParams.message = new ExpandoObject();
            sendParams.key = "";

            if (language == "tr")
            {
                sendParams.template_name = "congratulations_tr";
                sendParams.message.subject = "Yepp.app Bilgilendirme";
            }
            if (language == "en")
            {
                sendParams.template_name = "congratulations_en";
                sendParams.message.subject = "Yepp.app Information";

            }
            sendParams.template_content = new List<dynamic>();

            sendParams.message = new ExpandoObject();

            sendParams.message.from_email = emailFrom;
            sendParams.message.from_name = emailFromName;

            sendParams.message.to = new List<dynamic>();
            sendParams.message.to.Add(new ExpandoObject());
            sendParams.message.to[0].email = userEmail;
            sendParams.message.to[0].name = userName;

            sendParams.message.track_opens = true;

            MandrillError merr = SendMessage(sendParams);

            switch (merr)
            {
                case MandrillError.OK:
                    _mandrillResult.IsOk = true;
                    _mandrillResult.Message = "An activation link has been sent to your email address.";
                    break;
                case MandrillError.WebException:
                    _mandrillResult.Message = "An error occurred while sending the email";
                    _mandrillResult.IsOk = false;
                    break;
                case MandrillError.HttpNotOk:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an issue sending your activation e-mail. Please try again later or call us directly.";
                    break;
                case MandrillError.Invalid:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your email address appears to be invalid. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Rejected:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your activation email was rejected. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Unknown:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an unknown problem sending your activation email. Please try again, or call us directly.";
                    break;
            }
            return _mandrillResult;
        }
        
        public static async Task<MandrillResult> PaymesInfoEmailInformation(string Email, string Language, string Name, string Order)
        {
            _mandrillResult = new MandrillResult();
            dynamic sendParams = new ExpandoObject();
            sendParams.message = new ExpandoObject();
            sendParams.key = "";


            if (Language == "tr-Tr")
            {
                sendParams.template_name = "payment_tr";
                sendParams.message.subject = "Yepp.app Ödeme Bilgilendirmesi";
            }
            if (Language == "en-Us")
            {
                sendParams.template_name = "payment_en";
                sendParams.message.subject = "Yepp.app Payment Information";

            }
            sendParams.template_content = new List<dynamic>();


            sendParams.message.from_email = emailFrom;
            sendParams.message.from_name = emailFromName;
            sendParams.message.language = Language;

            sendParams.message.to = new List<dynamic>();
            sendParams.message.to.Add(new ExpandoObject());
            sendParams.message.to[0].email = Email;
            sendParams.message.to[0].name = Name;

            sendParams.message.track_opens = true;
            //sendParams.message.track_clicks = true;

            sendParams.message.global_merge_vars = new List<dynamic>();
            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[0].name = "name";
            sendParams.message.global_merge_vars[0].content = Name;

            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[1].name = "order";
            sendParams.message.global_merge_vars[1].content = Order;

            MandrillError merr = SendMessage(sendParams);

            switch (merr)
            {
                case MandrillError.OK:
                    _mandrillResult.IsOk = true;
                    _mandrillResult.Message = "An activation link has been sent to your email address.";
                    break;
                case MandrillError.WebException:
                    _mandrillResult.Message = "An error occurred while sending the email";
                    _mandrillResult.IsOk = false;
                    break;
                case MandrillError.HttpNotOk:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an issue sending your activation e-mail. Please try again later or call us directly.";
                    break;
                case MandrillError.Invalid:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your email address appears to be invalid. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Rejected:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your activation email was rejected. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Unknown:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an unknown problem sending your activation email. Please try again, or call us directly.";
                    break;
            }
            return _mandrillResult;
        }

        public static async Task<MandrillResult> GameInfoEmailInformation(string gameOrder, string userName, string userEmail, string language)
        {
            _mandrillResult = new MandrillResult();
            dynamic sendParams = new ExpandoObject();
            sendParams.message = new ExpandoObject();
            sendParams.key = "";

            if (language == "tr-Tr")
            {
                sendParams.template_name = "game_thank_you_tr";
                sendParams.message.subject = "Yepp.app Bilgilendirme";
            }
            if (language == "en-Us")
            {
                sendParams.template_name = "game_thank_you_en";
                sendParams.message.subject = "Yepp.app Information";

            }
            sendParams.template_content = new List<dynamic>();


            sendParams.message.from_email = emailFrom;
            sendParams.message.from_name = emailFromName;
            sendParams.message.language = language;

            sendParams.message.to = new List<dynamic>();
            sendParams.message.to.Add(new ExpandoObject());
            sendParams.message.to[0].email = userEmail;
            sendParams.message.to[0].name = userName;

            sendParams.message.track_opens = true;
            //sendParams.message.track_clicks = true;

            sendParams.message.global_merge_vars = new List<dynamic>();
            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[0].name = "USER_NAME";
            sendParams.message.global_merge_vars[0].content = userName;

            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[1].name = "GAME_ORDER";
            sendParams.message.global_merge_vars[1].content = gameOrder;

            MandrillError merr = SendMessage(sendParams);

            switch (merr)
            {
                case MandrillError.OK:
                    _mandrillResult.IsOk = true;
                    _mandrillResult.Message = "An activation link has been sent to your email address.";
                    break;
                case MandrillError.WebException:
                    _mandrillResult.Message = "An error occurred while sending the email";
                    _mandrillResult.IsOk = false;
                    break;
                case MandrillError.HttpNotOk:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an issue sending your activation e-mail. Please try again later or call us directly.";
                    break;
                case MandrillError.Invalid:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your email address appears to be invalid. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Rejected:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your activation email was rejected. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Unknown:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an unknown problem sending your activation email. Please try again, or call us directly.";
                    break;
            }
            return _mandrillResult;
        }

        public static async Task<MandrillError> SendMessage(dynamic parameters)
        {

            string url = MandrillBaseUrl + "/messages/send-template.json";

            var http = new EasyHttp.Http.HttpClient
            {
                Request = { Accept = HttpContentTypes.ApplicationJson }
            };

            EasyHttp.Http.HttpResponse response;
            try
            {
                response = http.Post(url, parameters, HttpContentTypes.ApplicationJson);
            }
            catch (WebException ex)
            {
                var _ex = ex.ToString();
                return MandrillError.WebException;
                throw;
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return MandrillError.HttpNotOk;
            }

            dynamic rv = response.DynamicBody;

            string send_status = rv[0].status;
            if (send_status == "sent" || send_status == "queued")
                return MandrillError.OK;

            // otherwise, it should be "rejected" or "invalid"
            if (send_status == "invalid")
            {
                return MandrillError.Invalid;
            }
            if (send_status == "rejected")
            {
                return MandrillError.Rejected;
            }

            // unexpected...
            return MandrillError.Unknown;
        }

        public static async Task<MandrillResult> UserForgotPassword(string userName, string userLastName, string language, string userEmail, string password)
        {
            _mandrillResult = new MandrillResult();
            dynamic sendParams = new ExpandoObject();
            sendParams.message = new ExpandoObject();
            sendParams.key = "";

            if (language == "tr")
            {
                sendParams.template_name = "forgot_password_tr";
                sendParams.message.subject = "Yepp.app Yeni Şifre";
            }
            if (language == "en")
            {
                sendParams.template_name = "forgot_password_en";
                sendParams.message.subject = "Yepp.app Forgot Password";

            }
            sendParams.template_content = new List<dynamic>();


            sendParams.message.from_email = emailFrom;
            sendParams.message.from_name = emailFromName;

            sendParams.message.to = new List<dynamic>();
            sendParams.message.to.Add(new ExpandoObject());
            sendParams.message.to[0].email = userEmail;
            sendParams.message.to[0].name = userName + " " + userLastName;

            sendParams.message.track_opens = true;
            //sendParams.message.track_clicks = true;

            sendParams.message.global_merge_vars = new List<dynamic>();
            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[0].name = "NAME";
            sendParams.message.global_merge_vars[0].content = userName;

            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[1].name = "SURNAME";
            sendParams.message.global_merge_vars[1].content = userLastName;

            sendParams.message.global_merge_vars.Add(new ExpandoObject());
            sendParams.message.global_merge_vars[2].name = "NEW_PASSWORD";
            sendParams.message.global_merge_vars[2].content = password;


            MandrillError merr = SendMessage(sendParams);

            switch (merr)
            {
                case MandrillError.OK:
                    _mandrillResult.IsOk = true;
                    _mandrillResult.Message = "An activation link has been sent to your email address.";
                    break;
                case MandrillError.WebException:
                    _mandrillResult.Message = "An error occurred while sending the email";
                    _mandrillResult.IsOk = false;
                    break;
                case MandrillError.HttpNotOk:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an issue sending your activation e-mail. Please try again later or call us directly.";
                    break;
                case MandrillError.Invalid:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your email address appears to be invalid. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Rejected:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "Your activation email was rejected. Please try again with a valid address, or call us directly.";
                    break;
                case MandrillError.Unknown:
                    _mandrillResult.IsOk = false;
                    _mandrillResult.Message = "There was an unknown problem sending your activation email. Please try again, or call us directly.";
                    break;
            }
            return _mandrillResult;
        }
    }
}