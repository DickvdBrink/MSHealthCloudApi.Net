using System;
using Newtonsoft.Json;

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
        public ErrorInformation Details { get; set; }
        [JsonPropertyAttribute("innererror")]
        public string Innererror { get; set; }

    }
}