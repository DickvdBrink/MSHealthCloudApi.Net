using System;

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
        public int steps { get; set; }
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