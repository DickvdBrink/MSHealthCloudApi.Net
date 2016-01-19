using System;

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
        public string firstName { get; set; }
        /// <summary>
        /// The user's middle name
        /// </summary>
        public string middleName { get; set; }
        /// <summary>
        /// The user's last name
        /// </summary>
        public string lastName { get; set; }
        /// <summary>
        /// The user's birth date
        /// </summary>
        public DateTime birthdate { get; set; }
        /// <summary>
        /// The user's postal code
        /// </summary>
        public string postalCode { get; set; }
        /// <summary>
        /// The user's gender
        /// </summary>
        public string gender { get; set; }
        /// <summary>
        /// The user's current height
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// The user's current weight
        /// </summary>
        public int weight { get; set; }
        /// <summary>
        /// The user's preferred locale
        /// </summary>
        public string preferredLocale { get; set; }
        /// <summary>
        /// The last update time of the user's profile record
        /// </summary>
        public DateTime lastUpdateTime { get; set; }
        
    }
}