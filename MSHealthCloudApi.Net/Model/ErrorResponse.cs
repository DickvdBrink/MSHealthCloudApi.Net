using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ErrorResponse
    {
        [JsonPropertyAttribute("error")]
        public string Error { get; set; }

    }
}