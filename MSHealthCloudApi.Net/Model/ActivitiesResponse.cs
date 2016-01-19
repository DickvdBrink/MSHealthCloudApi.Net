using System;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// The activity collection response.
    /// </summary>
    public class ActivitiesResponse
    {
        /// <summary>
        /// The collection of bike activities
        /// </summary>
        public BikeActivity bikeActivities { get; set; }
        /// <summary>
        /// The collection of free play activities
        /// </summary>
        public FreePlayActivity freePlayActivities { get; set; }
        /// <summary>
        /// The collection of golf activities
        /// </summary>
        public GolfActivity golfActivities { get; set; }
        /// <summary>
        /// The collection of guided workout activities
        /// </summary>
        public GuidedWorkoutActivity guidedWorkoutActivities { get; set; }
        /// <summary>
        /// The collection of run activities
        /// </summary>
        public RunActivity runActivities { get; set; }
        /// <summary>
        /// The collection of sleep activities
        /// </summary>
        public SleepActivity sleepActivities { get; set; }
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