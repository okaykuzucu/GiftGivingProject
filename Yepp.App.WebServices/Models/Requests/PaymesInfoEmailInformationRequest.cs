using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yepp.App.WebServices.Models.Requests
{
    public class PaymesInfoEmailInformationRequest
    {
        public string Order { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
    }
}