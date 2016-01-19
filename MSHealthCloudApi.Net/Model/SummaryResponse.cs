using System;

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
        public Summary summaries { get; set; }
        /// <summary>
        /// The URI for the next page of data
        /// </summary>
        public string nextPage { get; set; }
        /// <summary>
        /// The number of items returned
        /// </summary>
        public int itemCount { get; set; }
        
    }
}