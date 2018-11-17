﻿using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Acquirerdetails
    {
        [JsonProperty("authorizationNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AuthorizationNumber { get; set; }
        [JsonProperty("taxDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Taxdocument TaxDocument { get; set; }
    }
}