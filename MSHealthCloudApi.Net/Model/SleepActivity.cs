using System;

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
        public string activityType { get; set; }
        /// <summary>
        /// The segments associated with this activity
        /// </summary>
        public SleepSegment activitySegments { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was awake during the activity
        /// </summary>
        public string awakeDuration { get; set; }
        /// <summary>
        /// The ISO 8601 formatted total length of time the user was asleep during the activity
        /// </summary>
        public string sleepDuration { get; set; }
        /// <summary>
        /// The number of times the user woke up during the activity
        /// </summary>
        public int numberOfWakeups { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time it took the user to fall asleep
        /// </summary>
        public string fallAsleepDuration { get; set; }
        /// <summary>
        /// The ratio of sleep duration to total duration of the activity
        /// </summary>
        public int sleepEfficiencyPercentage { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was in a restless sleep state
        /// </summary>
        public string totalRestlessSleepDuration { get; set; }
        /// <summary>
        /// The ISO 8601 formatted length of time the user was in a restful sleep state
        /// </summary>
        public string totalRestfulSleepDuration { get; set; }
        /// <summary>
        /// The resting heart rate during the activity
        /// </summary>
        public int restingHeartRate { get; set; }
        /// <summary>
        /// The ISO 8601 formatted time the user fell asleep
        /// </summary>
        public DateTime fallAsleepTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted time the user woke up
        /// </summary>
        public DateTime wakeupTime { get; set; }
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