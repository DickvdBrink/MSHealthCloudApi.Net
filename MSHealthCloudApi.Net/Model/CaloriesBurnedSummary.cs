using System;
using Newtonsoft.Json;

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
        [JsonPropertyAttribute("period")]
        public string Period { get; set; }
        /// <summary>
        /// The total calories burned during the period
        /// </summary>
        [JsonPropertyAttribute("totalCalories")]
        public int TotalCalories { get; set; }

    }
}