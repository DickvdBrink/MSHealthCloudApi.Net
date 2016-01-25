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
    public class MSHealthCloudApiClient
    {
        private const string Scopes = "mshealth.ReadProfile mshealth.ReadDevices mshealth.ReadActivityHistory mshealth.ReadActivityLocation";
        private const string BaseHealthUri = "https://api.microsofthealth.net";

        private string token;

        private RestClient client;
        public MSHealthCloudApiClient(string token)
        {
            this.token = token;
            client = new RestClient(BaseHealthUri);
            client.ClearHandlers();
            client.AddHandler("*", new JsonNetDeserializer());
        }

        #region Activities

        public ActivitiesResponse GetActivities(string activityIds = null, string activityTypes = null, string activityIncludes = null,
            string deviceIds = null, DateTime? startTime = null, DateTime? endTime = null, SplitDistanceType? splitDistanceType = null, int? maxPageSize = null)
        {
            RestRequest request = prepareGetActivitiesRequest(activityIds, activityTypes, activityIncludes, deviceIds, startTime, endTime, splitDistanceType, maxPageSize);
            return performRequest<ActivitiesResponse>(request);
        }

        public Task<ActivitiesResponse> GetActivitiesAsync(string activityIds = null, string activityTypes = null, string activityIncludes = null,
            string deviceIds = null, DateTime? startTime = null, DateTime? endTime = null, SplitDistanceType? splitDistanceType = null, int? maxPageSize = null)
        {
            RestRequest request = prepareGetActivitiesRequest(activityIds, activityTypes, activityIncludes, deviceIds, startTime, endTime, splitDistanceType, maxPageSize);
            return performRequestAsync<ActivitiesResponse>(request);
        }

        private RestRequest prepareGetActivitiesRequest(string activityIds = null, string activityTypes = null, string activityIncludes = null,
            string deviceIds = null, DateTime? startTime = null, DateTime? endTime = null, SplitDistanceType? splitDistanceType = null, int? maxPageSize = null)
        {
            RestRequest request = createRequest("/v1/me/Activities");
            if (activityIds != null)
            {
                request.AddQueryParameter("activityIds", activityIds);
            }
            if (activityTypes != null)
            {
                request.AddQueryParameter("activityTypes", activityTypes);
            }
            if (activityIncludes != null)
            {
                request.AddQueryParameter("activityIncludes", activityIncludes);
            }
            if (deviceIds != null)
            {
                request.AddQueryParameter("deviceIds", deviceIds);
            }
            if (startTime.HasValue)
            {
                request.AddQueryParameter("startTime", startTime.ToString());
            }
            if (endTime.HasValue)
            {
                request.AddQueryParameter("endTime", endTime.ToString());
            }
            if (splitDistanceType.HasValue)
            {
                request.AddQueryParameter("splitDistanceType", splitDistanceType.ToString());
            }
            if (maxPageSize.HasValue)
            {
                request.AddQueryParameter("maxPageSize", maxPageSize.ToString());
            }
            return request;
        }

        public Activity GetActivity(string activityId, string activityIncludes = null)
        {
            RestRequest request = prepareGetActivityRequest(activityId, activityIncludes);
            return performRequest<Activity>(request);
        }

        public Task<Activity> GetActivityAsync(string activityId = null, string activityIncludes = null)
        {
            RestRequest request = prepareGetActivityRequest(activityId, activityIncludes);
            return performRequestAsync<Activity>(request);
        }

        private RestRequest prepareGetActivityRequest(string activityId = null, string activityIncludes = null)
        {
            RestRequest request = createRequest("/v1/me/Activities/{activityId}");
            request.AddUrlSegment("activityId", activityId);
            if (activityIncludes != null)
            {
                request.AddQueryParameter("activityIncludes", activityIncludes);
            }
            return request;
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

        public SummaryResponse GetSummaries(Period period, DateTime? startTime = null, DateTime? endTime = null, string deviceIds = null, int? maxPageSize = null)
        {
            RestRequest request = prepareGetSummariesRequest(period, startTime, endTime, deviceIds, maxPageSize);
            return performRequest<SummaryResponse>(request);
        }

        public Task<SummaryResponse> GetSummariesAsync(Period period, DateTime? startTime = null, DateTime? endTime = null, string deviceIds = null, int? maxPageSize = null)
        {
            RestRequest request = prepareGetSummariesRequest(period, startTime, endTime, deviceIds, maxPageSize);
            return performRequestAsync<SummaryResponse>(request);
        }

        private RestRequest prepareGetSummariesRequest(Period period, DateTime? startTime = null, DateTime? endTime = null, string deviceIds = null, int? maxPageSize = null)
        {
            RestRequest request = createRequest("/v1/me/Summaries/{period}");
            request.AddUrlSegment("period", period.ToString());

            if (startTime.HasValue)
            {
                request.AddQueryParameter("startTime", startTime.ToString());
            }
            if (endTime.HasValue)
            {
                request.AddQueryParameter("endTime", endTime.ToString());
            }
            if (deviceIds != null)
            {
                request.AddQueryParameter("deviceIds", deviceIds);
            }
            if (maxPageSize.HasValue)
            {
                request.AddQueryParameter("maxPageSize", maxPageSize.ToString());
            }
            return request;
        }

        #endregion

        #region RequestHelpers

        private RestRequest createRequest(string resource)
        {
            RestRequest request = new RestRequest(resource);
            request.AddHeader("Authorization", $"bearer { this.token }");
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
