using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvs_sample_asp_net_core
{
    public class Document {
        public string idType { get; set; }
        public string country { get; set; }
        public string abbrCountry { get; set; }
        public string abbr3Country { get; set; }
        public string  id { get; set; }
        public string dob { get; set; }
        public string issued { get; set; }
        public string expires {get; set;}
        public string fullName { get; set; }
        public string privateName {get; set;}
        public string familyName {get; set;}
        public string city {get; set;}
        public string state {get; set;}
        public string zip {get; set;}
        public string address {get; set;}
        [JsonProperty("class")]
        public string documentClass {get; set;}
        public string gender {get; set;}
        public string height {get; set;}
        public string eyes {get; set;}
        public string hair {get; set;}
        public string weight {get; set;}
        public string template {get; set;}
        public string firstName {get; set;}
        public string middleName {get; set;}
    }
}
