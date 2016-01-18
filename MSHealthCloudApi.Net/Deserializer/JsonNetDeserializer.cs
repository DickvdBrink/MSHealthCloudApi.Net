using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace MSHealthCloudApi.Net.Deserializer
{
    public class JsonNetDeserializer : IDeserializer
    {
        public string DateFormat
        {
            get; set;
        }

        public string Namespace
        {
            get; set;
        }

        public string RootElement
        {
            get; set;
        }

        public T Deserialize<T>(IRestResponse response)
        {
            var _serializer = new Newtonsoft.Json.JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include
            };
            return JsonConvert.DeserializeObject<T>(response.Content, _serializer);
        }
    }
}
