using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Swamid.Errorurl.Domain
{
    
    public class LoginErrors
    {
        [JsonPropertyName("culture")]
        public string culture { get; set; }
        [JsonPropertyName("switchLangText")]
        public string SwitchLangText { get; set; }
        [JsonPropertyName("switchLang")]
        public string SwitchLang { get; set; }
        [JsonPropertyName("switchLangImage")]
        public string SwitchLangImage { get; set; }
        [JsonPropertyName("technicalInformation")]
        public string TechnicalInformation { get; set; }
        [JsonPropertyName("contactInfo")]
        public string ContactInfo { get; set; }
        [JsonPropertyName("error")]
        public LoginError[] Errors { get; set; }
    }

    public class LoginError
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("header")]
        public string Header { get; set; }
        [JsonPropertyName("body")]
        public string[] Body { get; set; }
        [JsonPropertyName("context")]
        public LoginErrorContext[] context { get; set; }
    }

    public class LoginErrorContext
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("identifiers")]
        public string[] Identifiers { get; set; }
        [JsonPropertyName("header")]
        public string Header { get; set; }
        [JsonPropertyName("body")]
        public string[] Body { get; set; }
    }

}
