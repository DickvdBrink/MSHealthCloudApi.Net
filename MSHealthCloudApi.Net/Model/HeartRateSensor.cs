using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// The heart rate sensor data.
    /// </summary>
    public class HeartRateSensor
    {
        /// <summary>
        /// The heart rate reading
        /// </summary>
        [JsonPropertyAttribute("heartRate")]
        public int HeartRate { get; set; }
        /// <summary>
        /// The quality of the heart rate reading
        /// </summary>
        [JsonPropertyAttribute("quality")]
        public int Quality { get; set; }
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