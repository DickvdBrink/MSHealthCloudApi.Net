using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Free Play specific data for a Free Play activity
    /// </summary>
    public class FreePlayActivity
    {
        /// <summary>
        /// The type of this activity
        /// </summary>
        [JsonPropertyAttribute("activityType")]
        public string ActivityType { get; set; }
        /// <summary>
        /// The segments associated with this activity
        /// </summary>
        [JsonPropertyAttribute("activitySegments")]
        public FreePlaySegment ActivitySegments { get; set; }
        /// <summary>
        /// The performance summary for the activity
        /// </summary>
        [JsonPropertyAttribute("performanceSummary")]
        public string PerformanceSummary { get; set; }
        /// <summary>
        /// The summary of distance data during the activity
        /// </summary>
        [JsonPropertyAttribute("distanceSummary")]
        public string DistanceSummary { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was paused during the activity
        /// </summary>
        [JsonPropertyAttribute("pausedDuration")]
        public string PausedDuration { get; set; }
        /// <summary>
        /// The split distance used for the activity
        /// </summary>
        [JsonPropertyAttribute("splitDistance")]
        public long SplitDistance { get; set; }
        /// <summary>
        /// The map points for the activity
        /// </summary>
        [JsonPropertyAttribute("mapPoints")]
        public MapPoint MapPoints { get; set; }
        /// <summary>
        /// The unique identifier of the activity (unique by user)
        /// </summary>
        [JsonPropertyAttribute("id")]
        public string Id { get; set; }
        /// <summary>
        /// The unique identifier of the user who completed the activity
        /// </summary>
        [JsonPropertyAttribute("userId")]
        public string UserId { get; set; }
        /// <summary>
        /// The identifier of the device which generated the activity
        /// </summary>
        [JsonPropertyAttribute("deviceId")]
        public string DeviceId { get; set; }
        /// <summary>
        /// The ISO 8601 formatted start time of the activity
        /// </summary>
        [JsonPropertyAttribute("startTime")]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted end time of the activity
        /// </summary>
        [JsonPropertyAttribute("endTime")]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The mapping of an event to a logical date. For most events, other than sleep,
        /// the default assignment is based on the event's start time. This is subject to change
        /// in the future. For example, if a sleep activity starts before 5 AM, the DayId is the previous day.
        /// </summary>
        [JsonPropertyAttribute("dayId")]
        public DateTime DayId { get; set; }
        /// <summary>
        /// The ISO 8601 formatted time the activity was created
        /// </summary>
        [JsonPropertyAttribute("createdTime")]
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// The app that created the activity
        /// </summary>
        [JsonPropertyAttribute("createdBy")]
        public string CreatedBy { get; set; }
        /// <summary>
        /// The name of the activity
        /// </summary>
        [JsonPropertyAttribute("name")]
        public string Name { get; set; }
        /// <summary>
        /// The ISO 8601 formatted duration of the activity
        /// </summary>
        [JsonPropertyAttribute("duration")]
        public string Duration { get; set; }
        /// <summary>
        /// The summaries associated with this activity
        /// </summary>
        [JsonPropertyAttribute("minuteSummaries")]
        public Summary MinuteSummaries { get; set; }
        /// <summary>
        /// The summary of calories burned during the activity
        /// </summary>
        [JsonPropertyAttribute("caloriesBurnedSummary")]
        public string CaloriesBurnedSummary { get; set; }
        /// <summary>
        /// The heart rate summary for the activity
        /// </summary>
        [JsonPropertyAttribute("heartRateSummary")]
        public string HeartRateSummary { get; set; }
        /// <summary>
        /// The UV exposure as time in the sun.
        /// </summary>
        [JsonPropertyAttribute("uvExposure")]
        public string UvExposure { get; set; }

    }
}