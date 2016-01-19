using System;

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
        public string period { get; set; }
        /// <summary>
        /// The total distance during the period.
        /// If this is a time-based summary, e.g. hourly or daily, then this is the total distance of the period.
        /// If this is an activity split summary, e.g. splits of a run, then this is the split distance, e.g. 1 mile, 1 kilometer.
        /// For the last split of the activity, this value may be less than the full split distance.
        /// </summary>
        public long totalDistance { get; set; }
        /// <summary>
        /// The total distance covered on foot during the period
        /// </summary>
        public long totalDistanceOnFoot { get; set; }
        /// <summary>
        /// The absolute distance including any paused time distance during the period
        /// </summary>
        public long actualDistance { get; set; }
        /// <summary>
        /// The cumulative elevation gain accrued during the period in cm
        /// </summary>
        public int elevationGain { get; set; }
        /// <summary>
        /// The cumulative elevation loss accrued during this period in cm
        /// </summary>
        public int elevationLoss { get; set; }
        /// <summary>
        /// The maximum elevation during this period in cm
        /// </summary>
        public int maxElevation { get; set; }
        /// <summary>
        /// The minimum elevation during this period in cm
        /// </summary>
        public int minElevation { get; set; }
        /// <summary>
        /// The distance in cm between recorded GPS points
        /// </summary>
        public long waypointDistance { get; set; }
        /// <summary>
        /// The average speed during the period
        /// </summary>
        public int speed { get; set; }
        /// <summary>
        /// The average pace during the period
        /// </summary>
        public int pace { get; set; }
        /// <summary>
        /// The total distance to the end of this period divided by total time to the end of this period
        /// </summary>
        public int overallPace { get; set; }
        
    }
}