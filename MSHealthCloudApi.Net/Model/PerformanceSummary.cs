using System;

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
        public int finishHeartRate { get; set; }
        /// <summary>
        /// The heart rate one minute after the user finished the exercise
        /// </summary>
        public int recoveryHeartRateAt1Minute { get; set; }
        /// <summary>
        /// The heart rate two minutes after the user finished the exercise
        /// </summary>
        public int recoveryHeartRateAt2Minutes { get; set; }
        /// <summary>
        /// The breakdown of the heart rate zones during the exercise
        /// </summary>
        public string heartRateZones { get; set; }
        
    }
}