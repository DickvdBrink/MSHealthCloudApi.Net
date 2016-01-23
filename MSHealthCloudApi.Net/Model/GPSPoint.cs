// This file is automatically generated
using System;
using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonPropertyAttribute("speedOverGround")]
        public int SpeedOverGround { get; set; }
        /// <summary>
        /// The latitude for the GPS point in degrees * 10^7 (+ = North)
        /// </summary>
        [JsonPropertyAttribute("latitude")]
        public int Latitude { get; set; }
        /// <summary>
        /// The longitude for the GPS point in degrees * 10^7 (+ = East)
        /// </summary>
        [JsonPropertyAttribute("longitude")]
        public int Longitude { get; set; }
        /// <summary>
        /// The elevation from mean sea level in m * 100
        /// </summary>
        [JsonPropertyAttribute("elevationFromMeanSeaLevel")]
        public int ElevationFromMeanSeaLevel { get; set; }
        /// <summary>
        /// The estimated horizontal error in m * 100
        /// </summary>
        [JsonPropertyAttribute("estimatedHorizontalError")]
        public int EstimatedHorizontalError { get; set; }
        /// <summary>
        /// The estimated vertical error in m * 100
        /// </summary>
        [JsonPropertyAttribute("estimatedVerticalError")]
        public int EstimatedVerticalError { get; set; }

    }
}