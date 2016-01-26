using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Model
{
    [JsonConverter(typeof(ActivityConverter))]
    public interface IActivity
    {
    }
}