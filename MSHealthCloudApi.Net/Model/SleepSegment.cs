using System;

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
        public int sleepTime { get; set; }
        /// <summary>
        /// The mapping of the sleep segment to a logical date. This is the same as the DayId for the sleep activity
        /// </summary>
        public DateTime dayId { get; set; }
        /// <summary>
        /// The sleep state
        /// </summary>
        public string sleepType { get; set; }
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