using System;
using Newtonsoft.Json;

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
        [JsonPropertyAttribute("userId")]
        public string UserId { get; set; }
        /// <summary>
        /// The ISO 8601 formatted start time of the period
        /// </summary>
        [JsonPropertyAttribute("startTime")]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted end time of the period
        /// </summary>
        [JsonPropertyAttribute("endTime")]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted parent day of the period
        /// </summary>
        [JsonPropertyAttribute("parentDay")]
        public DateTime ParentDay { get; set; }
        /// <summary>
        /// True if the user transitioned time zones during this period, else false
        /// </summary>
        [JsonPropertyAttribute("isTransitDay")]
        public bool IsTransitDay { get; set; }
        /// <summary>
        /// The length of the time bucket for which the summary is calculated
        /// </summary>
        [JsonPropertyAttribute("period")]
        public string Period { get; set; }
        /// <summary>
        /// The ISO 8601 formatted duration of the period
        /// </summary>
        [JsonPropertyAttribute("duration")]
        public string Duration { get; set; }
        /// <summary>
        /// The total number of steps taken during the period
        /// </summary>
        [JsonPropertyAttribute("stepsTaken")]
        public int StepsTaken { get; set; }
        /// <summary>
        /// The summary of the calories burned during the period
        /// </summary>
        [JsonPropertyAttribute("caloriesBurnedSummary")]
        public string CaloriesBurnedSummary { get; set; }
        /// <summary>
        /// The summary of heart rate data during the period
        /// </summary>
        [JsonPropertyAttribute("heartRateSummary")]
        public string HeartRateSummary { get; set; }
        /// <summary>
        /// The summary of the distance data during the period
        /// </summary>
        [JsonPropertyAttribute("distanceSummary")]
        public string DistanceSummary { get; set; }
        /// <summary>
        /// The number of active hours during the period
        /// </summary>
        [JsonPropertyAttribute("activeHours")]
        public int ActiveHours { get; set; }
        /// <summary>
        /// The UV exposure as time in the sun.
        /// </summary>
        [JsonPropertyAttribute("uvExposure")]
        public string UvExposure { get; set; }

    }
}