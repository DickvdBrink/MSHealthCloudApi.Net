using System;

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
        public int heartRate { get; set; }
        /// <summary>
        /// The quality of the heart rate reading
        /// </summary>
        public int quality { get; set; }
        /// <summary>
        /// The timestamp for the sensor reading
        /// </summary>
        public DateTime timestamp { get; set; }
        /// <summary>
        /// The ISO 8601 formatted duration of the segment
        /// </summary>
        public string duration { get; set; }
        
    }
}