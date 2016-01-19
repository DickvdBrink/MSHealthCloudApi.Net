using System;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// ActivitySegment Class for Workouts
    /// </summary>
    public class FreePlaySegment
    {
        /// <summary>
        /// The summary of distance data during the segment
        /// </summary>
        public string distanceSummary { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was paused during the segment
        /// </summary>
        public string pausedDuration { get; set; }
        /// <summary>
        /// The mapping of the amount of time spent in a given heart rate zone during the segment
        /// </summary>
        public string heartRateZones { get; set; }
        /// <summary>
        /// The split distance used for the segment
        /// </summary>
        public long splitDistance { get; set; }
        /// <summary>
        /// The unique identifier of the segment
        /// </summary>
        public long segmentId { get; set; }
        /// <summary>
        /// The ISO 8601 formatted start time of the segment
        /// </summary>
        public DateTime startTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted end time of the segment
        /// </summary>
        public DateTime endTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted duration of the segment
        /// </summary>
        public string duration { get; set; }
        /// <summary>
        /// The heart rate summary for the segment
        /// </summary>
        public string heartRateSummary { get; set; }
        /// <summary>
        /// The summary of calories burned during the segment
        /// </summary>
        public string caloriesBurnedSummary { get; set; }
        /// <summary>
        /// The segment type
        /// </summary>
        public string segmentType { get; set; }
        
    }
}