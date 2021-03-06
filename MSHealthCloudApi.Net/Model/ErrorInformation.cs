// This file is automatically generated
using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ErrorInformation
    {
        [JsonPropertyAttribute("code")]
        public string Code { get; set; }
        [JsonPropertyAttribute("message")]
        public string Message { get; set; }
        [JsonPropertyAttribute("target")]
        public string Target { get; set; }
        [JsonPropertyAttribute("details")]
        public List<ErrorInformation> Details { get; set; }
        [JsonPropertyAttribute("innererror")]
        public ErrorInformation Innererror { get; set; }

    }
}