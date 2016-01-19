using System;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// GPS Point sensor
    /// </summary>
    public class GPSPoint
    {
        /// <summary>
        /// The speed over ground for the GPS point in m/s * 100
        /// </summary>
        public int speedOverGround { get; set; }
        /// <summary>
        /// The latitude for the GPS point in degrees * 10^7 (+ = North)
        /// </summary>
        public int latitude { get; set; }
        /// <summary>
        /// The longitude for the GPS point in degrees * 10^7 (+ = East)
        /// </summary>
        public int longitude { get; set; }
        /// <summary>
        /// The elevation from mean sea level in m * 100
        /// </summary>
        public int elevationFromMeanSeaLevel { get; set; }
        /// <summary>
        /// The estimated horizontal error in m * 100
        /// </summary>
        public int estimatedHorizontalError { get; set; }
        /// <summary>
        /// The estimated vertical error in m * 100
        /// </summary>
        public int estimatedVerticalError { get; set; }
        
    }
}