using System;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Golf specific data for a golfing activity
    /// </summary>
    public class GolfActivity
    {
        /// <summary>
        /// The type of this activity
        /// </summary>
        public string activityType { get; set; }
        /// <summary>
        /// The segments associated with this activity
        /// </summary>
        public GolfHoleSegment activitySegments { get; set; }
        /// <summary>
        /// The total number of steps a user took during the activity
        /// </summary>
        public int totalStepCount { get; set; }
        /// <summary>
        /// The total distance a user walked during the activity
        /// </summary>
        public int totalDistanceWalked { get; set; }
        /// <summary>
        /// The number of holes played where the user scored par or better during the activity
        /// </summary>
        public int parOrBetterCount { get; set; }
        /// <summary>
        /// The distance of the longest drive hit by the user during the activity
        /// </summary>
        public int longestDriveDistance { get; set; }
        /// <summary>
        /// The distance of the longest stroke hit by the user during the activity
        /// </summary>
        public int longestStrokeDistance { get; set; }
        /// <summary>
        /// The list of child activities
        /// </summary>
        public Activity childActivities { get; set; }
        /// <summary>
        /// The unique identifier of the activity (unique by user)
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// The unique identifier of the user who completed the activity
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// The identifier of the device which generated the activity
        /// </summary>
        public string deviceId { get; set; }
        /// <summary>
        /// The ISO 8601 formatted start time of the activity
        /// </summary>
        public DateTime startTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted end time of the activity
        /// </summary>
        public DateTime endTime { get; set; }
        /// <summary>
        /// The mapping of an event to a logical date. For most events, other than sleep,
        /// the default assignment is based on the event's start time. This is subject to change
        /// in the future. For example, if a sleep activity starts before 5 AM, the DayId is the previous day.
        /// </summary>
        public DateTime dayId { get; set; }
        /// <summary>
        /// The ISO 8601 formatted time the activity was created
        /// </summary>
        public DateTime createdTime { get; set; }
        /// <summary>
        /// The app that created the activity
        /// </summary>
        public string createdBy { get; set; }
        /// <summary>
        /// The name of the activity
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The ISO 8601 formatted duration of the activity
        /// </summary>
        public string duration { get; set; }
        /// <summary>
        /// The summaries associated with this activity
        /// </summary>
        public Summary minuteSummaries { get; set; }
        /// <summary>
        /// The summary of calories burned during the activity
        /// </summary>
        public string caloriesBurnedSummary { get; set; }
        /// <summary>
        /// The heart rate summary for the activity
        /// </summary>
        public string heartRateSummary { get; set; }
        /// <summary>
        /// The UV exposure as time in the sun.
        /// </summary>
        public string uvExposure { get; set; }
        
    }
}