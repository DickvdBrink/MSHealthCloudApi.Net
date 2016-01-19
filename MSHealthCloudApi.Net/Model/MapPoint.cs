using System;

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
        public int secondsSinceStart { get; set; }
        /// <summary>
        /// The type of map point
        /// </summary>
        public string mapPointType { get; set; }
        /// <summary>
        /// The absolute ordering of this point relative to the others in its set, starting from 0
        /// </summary>
        public int ordinal { get; set; }
        /// <summary>
        /// The distance not including distance traveled while paused, it is the distance that splits are based off of, since splits ignore paused time
        /// </summary>
        public long actualDistance { get; set; }
        /// <summary>
        /// The total distance from the start point to this map point
        /// </summary>
        public long totalDistance { get; set; }
        /// <summary>
        /// The heart rate at the time of this map point
        /// </summary>
        public int heartRate { get; set; }
        /// <summary>
        /// The pace
        /// </summary>
        public int pace { get; set; }
        /// <summary>
        /// A number between 0 and 100 that denotes the pace/speed between the slowest and fastest instantaneous pace for the
        /// overall route. Slowest segment in the route (highest pace, lowest speed) is 0 and fastest segment
        /// (lowest pace, highest speed) is 100. Only makes sense in the context of the set of all map points.
        /// </summary>
        public int scaledPace { get; set; }
        /// <summary>
        /// The speed
        /// </summary>
        public int speed { get; set; }
        /// <summary>
        /// The GPS location for this map point
        /// </summary>
        public string location { get; set; }
        /// <summary>
        /// A value indicating whether or not this map point occurred during paused time
        /// </summary>
        public bool isPaused { get; set; }
        /// <summary>
        /// A value indicating whether or not this map point is the first one since the activity resumed
        /// </summary>
        public bool isResume { get; set; }
        
    }
}