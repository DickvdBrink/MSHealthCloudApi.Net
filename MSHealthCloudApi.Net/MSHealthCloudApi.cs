using MSHealthCloudApi.Net.Deserializer;
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
        private RestClient client;
        public MSHealthCloudApi()
        {
            client = new RestClient();
            client.AddHandler("*", new JsonNetDeserializer());
            var req = new RestRequest();
            req.JsonSerializer = new JsonNetSerializer();
        }
    }
}
