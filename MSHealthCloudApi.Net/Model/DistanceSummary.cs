using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Distance Related Summary Information
    /// </summary>
    public class DistanceSummary
    {
        /// <summary>
        /// The length of the time bucket for which the summary is calculated
        /// </summary>
        [JsonPropertyAttribute("period")]
        public string Period { get; set; }
        /// <summary>
        /// The total distance during the period.
        /// If this is a time-based summary, e.g. hourly or daily, then this is the total distance of the period.
        /// If this is an activity split summary, e.g. splits of a run, then this is the split distance, e.g. 1 mile, 1 kilometer.
        /// For the last split of the activity, this value may be less than the full split distance.
        /// </summary>
        [JsonPropertyAttribute("totalDistance")]
        public long TotalDistance { get; set; }
        /// <summary>
        /// The total distance covered on foot during the period
        /// </summary>
        [JsonPropertyAttribute("totalDistanceOnFoot")]
        public long TotalDistanceOnFoot { get; set; }
        /// <summary>
        /// The absolute distance including any paused time distance during the period
        /// </summary>
        [JsonPropertyAttribute("actualDistance")]
        public long ActualDistance { get; set; }
        /// <summary>
        /// The cumulative elevation gain accrued during the period in cm
        /// </summary>
        [JsonPropertyAttribute("elevationGain")]
        public int ElevationGain { get; set; }
        /// <summary>
        /// The cumulative elevation loss accrued during this period in cm
        /// </summary>
        [JsonPropertyAttribute("elevationLoss")]
        public int ElevationLoss { get; set; }
        /// <summary>
        /// The maximum elevation during this period in cm
        /// </summary>
        [JsonPropertyAttribute("maxElevation")]
        public int MaxElevation { get; set; }
        /// <summary>
        /// The minimum elevation during this period in cm
        /// </summary>
        [JsonPropertyAttribute("minElevation")]
        public int MinElevation { get; set; }
        /// <summary>
        /// The distance in cm between recorded GPS points
        /// </summary>
        [JsonPropertyAttribute("waypointDistance")]
        public long WaypointDistance { get; set; }
        /// <summary>
        /// The average speed during the period
        /// </summary>
        [JsonPropertyAttribute("speed")]
        public int Speed { get; set; }
        /// <summary>
        /// The average pace during the period
        /// </summary>
        [JsonPropertyAttribute("pace")]
        public int Pace { get; set; }
        /// <summary>
        /// The total distance to the end of this period divided by total time to the end of this period
        /// </summary>
        [JsonPropertyAttribute("overallPace")]
        public int OverallPace { get; set; }

    }
}