using System;

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
        public int holeNumber { get; set; }
        /// <summary>
        /// The steps taken by the user for the hole
        /// </summary>
        public int stepCount { get; set; }
        /// <summary>
        /// The distance walked by the user for the hole
        /// </summary>
        public int distanceWalked { get; set; }
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