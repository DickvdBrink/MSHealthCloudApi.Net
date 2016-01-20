using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Summary of the Performance Metrics for an Exercise
    /// </summary>
    public class PerformanceSummary
    {
        /// <summary>
        /// The heart rate when the user finished the exercise
        /// </summary>
        [JsonPropertyAttribute("finishHeartRate")]
        public int FinishHeartRate { get; set; }
        /// <summary>
        /// The heart rate one minute after the user finished the exercise
        /// </summary>
        [JsonPropertyAttribute("recoveryHeartRateAt1Minute")]
        public int RecoveryHeartRateAt1Minute { get; set; }
        /// <summary>
        /// The heart rate two minutes after the user finished the exercise
        /// </summary>
        [JsonPropertyAttribute("recoveryHeartRateAt2Minutes")]
        public int RecoveryHeartRateAt2Minutes { get; set; }
        /// <summary>
        /// The breakdown of the heart rate zones during the exercise
        /// </summary>
        [JsonPropertyAttribute("heartRateZones")]
        public string HeartRateZones { get; set; }

    }
}