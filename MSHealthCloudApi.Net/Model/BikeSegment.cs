using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// ActivitySegment of a segment of biking
    /// </summary>
    public class BikeSegment
    {
        /// <summary>
        /// The summary of distance data during the segment
        /// </summary>
        [JsonPropertyAttribute("distanceSummary")]
        public string DistanceSummary { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was paused during the segment
        /// </summary>
        [JsonPropertyAttribute("pausedDuration")]
        public string PausedDuration { get; set; }
        /// <summary>
        /// The mapping of the amount of time spent in a given heart rate zone during the segment
        /// </summary>
        [JsonPropertyAttribute("heartRateZones")]
        public string HeartRateZones { get; set; }
        /// <summary>
        /// The split distance used for the segment
        /// </summary>
        [JsonPropertyAttribute("splitDistance")]
        public long SplitDistance { get; set; }
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