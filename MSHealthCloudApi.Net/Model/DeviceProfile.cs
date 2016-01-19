using System;

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
        public string id { get; set; }
        /// <summary>
        /// The name the user has given the device.  (Not available in the Developer Preview)
        /// </summary>
        public string displayName { get; set; }
        /// <summary>
        /// The date the device was last synced with the service.  (Not available in the Developer Preview)
        /// </summary>
        public DateTime lastSuccessfulSync { get; set; }
        /// <summary>
        /// The device family
        /// </summary>
        public string deviceFamily { get; set; }
        /// <summary>
        /// The device version
        /// </summary>
        public string hardwareVersion { get; set; }
        /// <summary>
        /// The device's software version
        /// </summary>
        public string softwareVersion { get; set; }
        /// <summary>
        /// The name of the model of the device
        /// </summary>
        public string modelName { get; set; }
        /// <summary>
        /// The name of the manufacturer of the device
        /// </summary>
        public string manufacturer { get; set; }
        /// <summary>
        /// The current status of the device
        /// </summary>
        public string deviceStatus { get; set; }
        /// <summary>
        /// The date the device was first registered  (Not available in the Developer Preview)
        /// </summary>
        public DateTime createdDate { get; set; }
        
    }
}