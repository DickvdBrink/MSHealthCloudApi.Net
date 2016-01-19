using System;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Calories Burned Summary Information
    /// </summary>
    public class CaloriesBurnedSummary
    {
        /// <summary>
        /// The length of the time bucket for which the summary is calculated
        /// </summary>
        public string period { get; set; }
        /// <summary>
        /// The total calories burned during the period
        /// </summary>
        public int totalCalories { get; set; }
        
    }
}