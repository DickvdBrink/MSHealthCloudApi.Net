using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Sleep specific data for a sleep activity
    /// </summary>
    public class SleepActivity
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
        public SleepSegment ActivitySegments { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was awake during the activity
        /// </summary>
        [JsonPropertyAttribute("awakeDuration")]
        public string AwakeDuration { get; set; }
        /// <summary>
        /// The ISO 8601 formatted total length of time the user was asleep during the activity
        /// </summary>
        [JsonPropertyAttribute("sleepDuration")]
        public string SleepDuration { get; set; }
        /// <summary>
        /// The number of times the user woke up during the activity
        /// </summary>
        [JsonPropertyAttribute("numberOfWakeups")]
        public int NumberOfWakeups { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time it took the user to fall asleep
        /// </summary>
        [JsonPropertyAttribute("fallAsleepDuration")]
        public string FallAsleepDuration { get; set; }
        /// <summary>
        /// The ratio of sleep duration to total duration of the activity
        /// </summary>
        [JsonPropertyAttribute("sleepEfficiencyPercentage")]
        public int SleepEfficiencyPercentage { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was in a restless sleep state
        /// </summary>
        [JsonPropertyAttribute("totalRestlessSleepDuration")]
        public string TotalRestlessSleepDuration { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was in a restful sleep state
        /// </summary>
        [JsonPropertyAttribute("totalRestfulSleepDuration")]
        public string TotalRestfulSleepDuration { get; set; }
        /// <summary>
        /// The resting heart rate during the activity
        /// </summary>
        [JsonPropertyAttribute("restingHeartRate")]
        public int RestingHeartRate { get; set; }
        /// <summary>
        /// The ISO 8601 formatted time the user fell asleep
        /// </summary>
        [JsonPropertyAttribute("fallAsleepTime")]
        public DateTime FallAsleepTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted time the user woke up
        /// </summary>
        [JsonPropertyAttribute("wakeupTime")]
        public DateTime WakeupTime { get; set; }
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