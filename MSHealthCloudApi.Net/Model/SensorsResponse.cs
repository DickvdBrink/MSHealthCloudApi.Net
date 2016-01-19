using System;

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
        public DateTime startTime { get; set; }
        /// <summary>
        /// The ISO 8601 formatted end time
        /// </summary>
        public DateTime endTime { get; set; }
        /// <summary>
        /// The unique identifier of the device
        /// </summary>
        public string deviceId { get; set; }
        /// <summary>
        /// The collection of steps sensor data
        /// </summary>
        public StepSensor steps { get; set; }
        /// <summary>
        /// The collection of heart rates sensor data
        /// </summary>
        public HeartRateSensor heartRates { get; set; }
        /// <summary>
        /// The URI for the next page of data
        /// </summary>
        public string nextPage { get; set; }
        /// <summary>
        /// The number of items returned
        /// </summary>
        public int itemCount { get; set; }
        
    }
}