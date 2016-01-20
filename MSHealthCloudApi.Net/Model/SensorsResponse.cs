using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Represents the response for sensor data
    /// </summary>
    public class SensorsResponse
    {
        /// <summary>
        /// The ISO 8601 formatted start time
        /// </summary>
        [JsonPropertyAttribute("startTime")]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted end time
        /// </summary>
        [JsonPropertyAttribute("endTime")]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The unique identifier of the device
        /// </summary>
        [JsonPropertyAttribute("deviceId")]
        public string DeviceId { get; set; }
        /// <summary>
        /// The collection of steps sensor data
        /// </summary>
        [JsonPropertyAttribute("steps")]
        public StepSensor Steps { get; set; }
        /// <summary>
        /// The collection of heart rates sensor data
        /// </summary>
        [JsonPropertyAttribute("heartRates")]
        public HeartRateSensor HeartRates { get; set; }
        /// <summary>
        /// The URI for the next page of data
        /// </summary>
        [JsonPropertyAttribute("nextPage")]
        public string NextPage { get; set; }
        /// <summary>
        /// The number of items returned
        /// </summary>
        [JsonPropertyAttribute("itemCount")]
        public int ItemCount { get; set; }

    }
}