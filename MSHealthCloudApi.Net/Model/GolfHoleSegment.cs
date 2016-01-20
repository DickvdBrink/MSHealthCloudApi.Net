using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// ActivitySegment class for Golf Hole
    /// </summary>
    public class GolfHoleSegment
    {
        /// <summary>
        /// The hole number on the golf course
        /// </summary>
        [JsonPropertyAttribute("holeNumber")]
        public int HoleNumber { get; set; }
        /// <summary>
        /// The steps taken by the user for the hole
        /// </summary>
        [JsonPropertyAttribute("stepCount")]
        public int StepCount { get; set; }
        /// <summary>
        /// The distance walked by the user for the hole
        /// </summary>
        [JsonPropertyAttribute("distanceWalked")]
        public int DistanceWalked { get; set; }
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