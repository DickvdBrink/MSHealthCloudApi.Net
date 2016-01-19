using System;

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
        public string period { get; set; }
        /// <summary>
        /// The average heart rate achieved during the period
        /// </summary>
        public int averageHeartRate { get; set; }
        /// <summary>
        /// The peak heart rate achieved during the period
        /// </summary>
        public int peakHeartRate { get; set; }
        /// <summary>
        /// The lowest heart rate achieved during the period
        /// </summary>
        public int lowestHeartRate { get; set; }
        
    }
}