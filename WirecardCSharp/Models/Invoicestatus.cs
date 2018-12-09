﻿using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Invoicestatus
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Code { get; set; }
    }
}