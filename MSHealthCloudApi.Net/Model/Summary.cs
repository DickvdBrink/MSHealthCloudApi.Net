using System;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Summary information over a period of time
    /// </summary>
    public class Summary
    {
        /// <summary>
        /// The unique identifier of the user
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// The ISO 8601 formatted start time of the period
        /// </summary>
        public DateTime startTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted end time of the period
        /// </summary>
        public DateTime endTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted parent day of the period
        /// </summary>
        public DateTime parentDay { get; set; }
        /// <summary>
        /// True if the user transitioned time zones during this period, else false
        /// </summary>
        public bool isTransitDay { get; set; }
        /// <summary>
        /// The length of the time bucket for which the summary is calculated
        /// </summary>
        public string period { get; set; }
        /// <summary>
        /// The ISO 8601 formatted duration of the period
        /// </summary>
        public string duration { get; set; }
        /// <summary>
        /// The total number of steps taken during the period
        /// </summary>
        public int stepsTaken { get; set; }
        /// <summary>
        /// The summary of the calories burned during the period
        /// </summary>
        public string caloriesBurnedSummary { get; set; }
        /// <summary>
        /// The summary of heart rate data during the period
        /// </summary>
        public string heartRateSummary { get; set; }
        /// <summary>
        /// The summary of the distance data during the period
        /// </summary>
        public string distanceSummary { get; set; }
        /// <summary>
        /// The number of active hours during the period
        /// </summary>
        public int activeHours { get; set; }
        /// <summary>
        /// The UV exposure as time in the sun.
        /// </summary>
        public string uvExposure { get; set; }
        
    }
}