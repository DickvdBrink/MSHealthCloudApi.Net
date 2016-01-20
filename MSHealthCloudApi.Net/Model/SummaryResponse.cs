using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// The summary response.
    /// </summary>
    public class SummaryResponse
    {
        /// <summary>
        /// The collection of summaries
        /// </summary>
        [JsonPropertyAttribute("summaries")]
        public Summary Summaries { get; set; }
        /// <summary>
        /// The URI for the next page of data
        /// </summary>
        [JsonPropertyAttribute("nextPage")]
        public string NextPage { get; set; }
        /// <summary>
        /// The number of items returned
        /// </summary>
        [JsonPropertyAttribute("itemCount")]
        public int ItemCount { get; set; }

    }
}