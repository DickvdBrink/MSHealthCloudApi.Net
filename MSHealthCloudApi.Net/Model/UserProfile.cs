using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// Information about the User
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// The user's first name
        /// </summary>
        [JsonPropertyAttribute("firstName")]
        public string FirstName { get; set; }
        /// <summary>
        /// The user's middle name
        /// </summary>
        [JsonPropertyAttribute("middleName")]
        public string MiddleName { get; set; }
        /// <summary>
        /// The user's last name
        /// </summary>
        [JsonPropertyAttribute("lastName")]
        public string LastName { get; set; }
        /// <summary>
        /// The user's birth date
        /// </summary>
        [JsonPropertyAttribute("birthdate")]
        public DateTime Birthdate { get; set; }
        /// <summary>
        /// The user's postal code
        /// </summary>
        [JsonPropertyAttribute("postalCode")]
        public string PostalCode { get; set; }
        /// <summary>
        /// The user's gender
        /// </summary>
        [JsonPropertyAttribute("gender")]
        public string Gender { get; set; }
        /// <summary>
        /// The user's current height
        /// </summary>
        [JsonPropertyAttribute("height")]
        public int Height { get; set; }
        /// <summary>
        /// The user's current weight
        /// </summary>
        [JsonPropertyAttribute("weight")]
        public int Weight { get; set; }
        /// <summary>
        /// The user's preferred locale
        /// </summary>
        [JsonPropertyAttribute("preferredLocale")]
        public string PreferredLocale { get; set; }
        /// <summary>
        /// The last update time of the user's profile record
        /// </summary>
        [JsonPropertyAttribute("lastUpdateTime")]
        public DateTime LastUpdateTime { get; set; }

    }
}