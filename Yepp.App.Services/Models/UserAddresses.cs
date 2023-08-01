using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Yepp.App.Services.Models
{
   public class UserAddresses
    {
        [JsonPropertyName("addressLine")]
        public string AddressLine { get; set; }

        [JsonPropertyName("City")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("postCode")]
        public string PostCode { get; set; }
    }
}

