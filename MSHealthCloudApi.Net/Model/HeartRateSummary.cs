using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Heart rate related summary information
    /// </summary>
    public class HeartRateSummary
    {
        /// <summary>
        /// The length of the time bucket for which the summary is calculated
        /// </summary>
        [JsonPropertyAttribute("period")]
        public string Period { get; set; }
        /// <summary>
        /// The average heart rate achieved during the period
        /// </summary>
        [JsonPropertyAttribute("averageHeartRate")]
        public int AverageHeartRate { get; set; }
        /// <summary>
        /// The peak heart rate achieved during the period
        /// </summary>
        [JsonPropertyAttribute("peakHeartRate")]
        public int PeakHeartRate { get; set; }
        /// <summary>
        /// The lowest heart rate achieved during the period
        /// </summary>
        [JsonPropertyAttribute("lowestHeartRate")]
        public int LowestHeartRate { get; set; }

    }
}