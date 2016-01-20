using MSHealthCloudApi.Net.Deserializer;
using MSHealthCloudApi.Net.Model;
using MSHealthCloudApi.Net.Serializers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSHealthCloudApi.Net
{
    public class MSHealthCloudApi
    {
        private const string Scopes = "mshealth.ReadDevices mshealth.ReadActivityHistory mshealth.ReadActivityLocation";
        private const string BaseHealthUri = "https://api.microsofthealth.net";

        private RestClient client;
        public MSHealthCloudApi()
        {
            client = new RestClient(BaseHealthUri);
            client.AddHandler("*", new JsonNetDeserializer());
        }

        #region Activities

        public ActivitiesResponse GetActivities()
        {
            return performRequest<ActivitiesResponse>("/v1/me/Activities");
        }

        #endregion

        #region Devices

        public List<DeviceProfile> GetDevicesProfile()
        {
            return performRequest<List<DeviceProfile>>("/v1/me/Devices");
        }

        public Task<List<DeviceProfile>> GetDevicesProfileAsync()
        {
            return performRequestAsync<List<DeviceProfile>>("/v1/me/Devices");
        }

        public DeviceProfile GetDeviceProfile(string deviceId)
        {
            RestRequest request = createRequest("/v1/me/Devices/{deviceId}");
            request.AddUrlSegment("deviceId", deviceId);
            return performRequest<DeviceProfile>(request);
        }

        public Task<DeviceProfile> GetDeviceProfileAsync(string deviceId)
        {
            RestRequest request = createRequest("/v1/me/Devices/{deviceId}");
            request.AddUrlSegment("deviceId", deviceId);
            return performRequestAsync<DeviceProfile>(request);
        }

        #endregion

        #region UserProfile

        public UserProfile GetUserProfile()
        {
            return performRequest<UserProfile>("/v1/me/Profile");
        }

        public Task<UserProfile> GetUserProfileAsync()
        {
            return performRequestAsync<UserProfile>("/v1/me/Profile");
        }

        #endregion

        #region Summaries

        #endregion

        #region RequestHelpers

        private RestRequest createRequest(string resource)
        {
            RestRequest request = new RestRequest(resource);
            request.AddHeader("Authorization", $"bearer { null }");
            request.JsonSerializer = new JsonNetSerializer();
            return request;
        }

        private T performRequest<T>(string resource)
            where T : new()
        {
            return performRequest<T>(createRequest(resource));
        }

        private T performRequest<T>(RestRequest request)
            where T : new()
        {
            IRestResponse<T> response = client.Get<T>(request);
            return response.Data;
        }

        private Task<T> performRequestAsync<T>(string resource)
            where T : new()
        {
            return performRequestAsync<T>(createRequest(resource));
        }

        private Task<T> performRequestAsync<T>(RestRequest request)
            where T : new()
        {
            Task<T> response = client.GetTaskAsync<T>(request);
            return response;
        }

        #endregion
    }
}
