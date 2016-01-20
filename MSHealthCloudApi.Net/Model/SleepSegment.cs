using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// ActivitySegment class for Sleeps
    /// </summary>
    public class SleepSegment
    {
        /// <summary>
        /// The length of time in minutes the user was asleep during the segment
        /// </summary>
        [JsonPropertyAttribute("sleepTime")]
        public int SleepTime { get; set; }
        /// <summary>
        /// The mapping of the sleep segment to a logical date. This is the same as the DayId for the sleep activity
        /// </summary>
        [JsonPropertyAttribute("dayId")]
        public DateTime DayId { get; set; }
        /// <summary>
        /// The sleep state
        /// </summary>
        [JsonPropertyAttribute("sleepType")]
        public string SleepType { get; set; }
        /// <summary>
        /// The unique identifier of the segment
        /// </summary>
        [JsonPropertyAttribute("segmentId")]
        public long SegmentId { get; set; }
        /// <summary>
        /// The ISO 8601 formatted start time of the segment
        /// </summary>
        [JsonPropertyAttribute("startTime")]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted end time of the segment
        /// </summary>
        [JsonPropertyAttribute("endTime")]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted duration of the segment
        /// </summary>
        [JsonPropertyAttribute("duration")]
        public string Duration { get; set; }
        /// <summary>
        /// The heart rate summary for the segment
        /// </summary>
        [JsonPropertyAttribute("heartRateSummary")]
        public string HeartRateSummary { get; set; }
        /// <summary>
        /// The summary of calories burned during the segment
        /// </summary>
        [JsonPropertyAttribute("caloriesBurnedSummary")]
        public string CaloriesBurnedSummary { get; set; }
        /// <summary>
        /// The segment type
        /// </summary>
        [JsonPropertyAttribute("segmentType")]
        public string SegmentType { get; set; }

    }
}