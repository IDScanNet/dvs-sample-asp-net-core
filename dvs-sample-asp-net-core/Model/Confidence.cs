using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvs_sample_asp_net_core
{
    public class Confidence
    {
        public int idType { get; set; }
        public int country { get; set; }
        public int abbrCountry { get; set; }
        public int abbr3Country { get; set; }
        public int id { get; set; }
        public int dob { get; set; }
        public int issued { get; set; }
        public int expires { get; set; }
        public int fullName { get; set; }
        public int privateName { get; set; }
        public int familyName { get; set; }
        public int city { get; set; }
        public int state { get; set; }
        public int zip { get; set; }
        public int address { get; set; }
        [JsonProperty("class")]
        public int confidencClass { get; set; }
        public int gender { get; set; }
        public int height { get; set; }
        public int eyes { get; set; }
        public int hair { get; set; }
        public int weight { get; set; }
        public int template { get; set; }
        public int firstName { get; set; }
        public int middleName { get; set; }

    }
}
