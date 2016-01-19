using System;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ErrorInformation
    {
        public string code { get; set; }
        public string message { get; set; }
        public string target { get; set; }
        public ErrorInformation details { get; set; }
        public string innererror { get; set; }
        
    }
}