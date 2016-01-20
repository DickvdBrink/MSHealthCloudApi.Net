using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Map Point Summary Data
    /// </summary>
    public class MapPoint
    {
        /// <summary>
        /// The number of seconds that have elapsed since mapping began, typically the start of a run or other activity
        /// </summary>
        [JsonPropertyAttribute("secondsSinceStart")]
        public int SecondsSinceStart { get; set; }
        /// <summary>
        /// The type of map point
        /// </summary>
        [JsonPropertyAttribute("mapPointType")]
        public string MapPointType { get; set; }
        /// <summary>
        /// The absolute ordering of this point relative to the others in its set, starting from 0
        /// </summary>
        [JsonPropertyAttribute("ordinal")]
        public int Ordinal { get; set; }
        /// <summary>
        /// The distance not including distance traveled while paused, it is the distance that splits are based off of, since splits ignore paused time
        /// </summary>
        [JsonPropertyAttribute("actualDistance")]
        public long ActualDistance { get; set; }
        /// <summary>
        /// The total distance from the start point to this map point
        /// </summary>
        [JsonPropertyAttribute("totalDistance")]
        public long TotalDistance { get; set; }
        /// <summary>
        /// The heart rate at the time of this map point
        /// </summary>
        [JsonPropertyAttribute("heartRate")]
        public int HeartRate { get; set; }
        /// <summary>
        /// The pace
        /// </summary>
        [JsonPropertyAttribute("pace")]
        public int Pace { get; set; }
        /// <summary>
        /// A number between 0 and 100 that denotes the pace/speed between the slowest and fastest instantaneous pace for the
        /// overall route. Slowest segment in the route (highest pace, lowest speed) is 0 and fastest segment
        /// (lowest pace, highest speed) is 100. Only makes sense in the context of the set of all map points.
        /// </summary>
        [JsonPropertyAttribute("scaledPace")]
        public int ScaledPace { get; set; }
        /// <summary>
        /// The speed
        /// </summary>
        [JsonPropertyAttribute("speed")]
        public int Speed { get; set; }
        /// <summary>
        /// The GPS location for this map point
        /// </summary>
        [JsonPropertyAttribute("location")]
        public string Location { get; set; }
        /// <summary>
        /// A value indicating whether or not this map point occurred during paused time
        /// </summary>
        [JsonPropertyAttribute("isPaused")]
        public bool IsPaused { get; set; }
        /// <summary>
        /// A value indicating whether or not this map point is the first one since the activity resumed
        /// </summary>
        [JsonPropertyAttribute("isResume")]
        public bool IsResume { get; set; }

    }
}