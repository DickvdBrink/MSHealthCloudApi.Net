using System;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    /// <summary>
    /// The Device Profile Information
    /// </summary>
    public class DeviceProfile
    {
        /// <summary>
        /// The unique identifier of the device
        /// </summary>
        [JsonPropertyAttribute("id")]
        public string Id { get; set; }
        /// <summary>
        /// The name the user has given the device.  (Not available in the Developer Preview)
        /// </summary>
        [JsonPropertyAttribute("displayName")]
        public string DisplayName { get; set; }
        /// <summary>
        /// The date the device was last synced with the service.  (Not available in the Developer Preview)
        /// </summary>
        [JsonPropertyAttribute("lastSuccessfulSync")]
        public DateTime LastSuccessfulSync { get; set; }
        /// <summary>
        /// The device family
        /// </summary>
        [JsonPropertyAttribute("deviceFamily")]
        public string DeviceFamily { get; set; }
        /// <summary>
        /// The device version
        /// </summary>
        [JsonPropertyAttribute("hardwareVersion")]
        public string HardwareVersion { get; set; }
        /// <summary>
        /// The device's software version
        /// </summary>
        [JsonPropertyAttribute("softwareVersion")]
        public string SoftwareVersion { get; set; }
        /// <summary>
        /// The name of the model of the device
        /// </summary>
        [JsonPropertyAttribute("modelName")]
        public string ModelName { get; set; }
        /// <summary>
        /// The name of the manufacturer of the device
        /// </summary>
        [JsonPropertyAttribute("manufacturer")]
        public string Manufacturer { get; set; }
        /// <summary>
        /// The current status of the device
        /// </summary>
        [JsonPropertyAttribute("deviceStatus")]
        public string DeviceStatus { get; set; }
        /// <summary>
        /// The date the device was first registered  (Not available in the Developer Preview)
        /// </summary>
        [JsonPropertyAttribute("createdDate")]
        public DateTime CreatedDate { get; set; }

    }
}