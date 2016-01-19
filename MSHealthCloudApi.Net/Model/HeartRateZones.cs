using System;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Distribution of Heart Rates through a range of values defined by Fitness experts 
    /// which determine the effectiveness of the exercise
    /// </summary>
    public class HeartRateZones
    {
        /// <summary>
        /// The number of minutes where the HR was below 50% of the user’s max HR
        /// </summary>
        public int underHealthyHeart { get; set; }
        /// <summary>
        /// Note: this field is deprecated. The correct field name is now UnderHealthyHeart. Populated for backwards compatibility until V2
        /// The number of minutes where the HR was below 50% of the user’s max HR
        /// </summary>
        public int underAerobic { get; set; }
        /// <summary>
        /// The number of minutes where the HR was between 70-80% of the user’s max HR
        /// </summary>
        public int aerobic { get; set; }
        /// <summary>
        /// The number of minutes where the HR was between 80-90% of the user’s max HR
        /// </summary>
        public int anaerobic { get; set; }
        /// <summary>
        /// The number of minutes where the HR was between 60-70% of the user’s max HR
        /// </summary>
        public int fitnessZone { get; set; }
        /// <summary>
        /// The number of minutes where the HR was between 50-60% of the user’s max HR
        /// </summary>
        public int healthyHeart { get; set; }
        /// <summary>
        /// The number of minutes where the HR was between 90-100% of the user’s max HR
        /// </summary>
        public int redline { get; set; }
        /// <summary>
        /// The number of minutes above the user’s max HR
        /// </summary>
        public int overRedline { get; set; }
        
    }
}