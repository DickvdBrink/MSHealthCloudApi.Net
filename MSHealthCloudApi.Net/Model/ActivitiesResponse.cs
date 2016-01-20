using System;
using Newtonsoft.Json;

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
        [JsonPropertyAttribute("bikeActivities")]
        public BikeActivity BikeActivities { get; set; }
        /// <summary>
        /// The collection of free play activities
        /// </summary>
        [JsonPropertyAttribute("freePlayActivities")]
        public FreePlayActivity FreePlayActivities { get; set; }
        /// <summary>
        /// The collection of golf activities
        /// </summary>
        [JsonPropertyAttribute("golfActivities")]
        public GolfActivity GolfActivities { get; set; }
        /// <summary>
        /// The collection of guided workout activities
        /// </summary>
        [JsonPropertyAttribute("guidedWorkoutActivities")]
        public GuidedWorkoutActivity GuidedWorkoutActivities { get; set; }
        /// <summary>
        /// The collection of run activities
        /// </summary>
        [JsonPropertyAttribute("runActivities")]
        public RunActivity RunActivities { get; set; }
        /// <summary>
        /// The collection of sleep activities
        /// </summary>
        [JsonPropertyAttribute("sleepActivities")]
        public SleepActivity SleepActivities { get; set; }
        /// <summary>
        /// The URI for the next page of data
        /// </summary>
        [JsonPropertyAttribute("nextPage")]
        public string NextPage { get; set; }
        /// <summary>
        /// The number of items returned
        /// </summary>
        [JsonPropertyAttribute("itemCount")]
        public int ItemCount { get; set; }

    }
}