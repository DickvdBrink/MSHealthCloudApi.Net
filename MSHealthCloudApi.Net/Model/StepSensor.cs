using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Defines the class for sensors that measure steps.
    /// </summary>
    public class StepSensor
    {
        /// <summary>
        /// The Steps reading from a device like a pedometer
        /// </summary>
        [JsonPropertyAttribute("steps")]
        public int Steps { get; set; }
        /// <summary>
        /// The timestamp for the sensor reading
        /// </summary>
        [JsonPropertyAttribute("timestamp")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// The ISO 8601 formatted duration of the segment
        /// </summary>
        [JsonPropertyAttribute("duration")]
        public string Duration { get; set; }

    }
}