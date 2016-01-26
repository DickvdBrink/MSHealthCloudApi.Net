using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MSHealthCloudApi.Net.Model;

namespace MSHealthCloudApi.Net
{
    internal class ActivityConverter : JsonConverter
    {
        private static Dictionary<string, Type> types;

        static ActivityConverter()
        {
            // TODO: Are there any types missing? These are in the docs
            Dictionary<string, Type> dict = new Dictionary<string, Type>()
            {
                { "Unknown", typeof (Activity) },
                { "Sleep", typeof(SleepActivity) },
                { "FreePlay", typeof(FreePlayActivity) },
                { "Run", typeof(RunActivity) },
                { "GuidedWorkout", typeof(GuidedWorkoutActivity) },
                { "Bike", typeof(BikeActivity) },
                { "Golf", typeof(GolfActivity) },
            };
            types = dict;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);
            JToken token;
            object instance = null;
            if (obj.TryGetValue("activityType", out token) && types.ContainsKey(token.ToString())
                // If the requested type is of Activity but the Token is for example Run
                // We still want to return Activity - or it will crash with a cast exception
                // In the future the other Activities should use Activity as a base class
                && !typeof(Activity).Equals(objectType))
            {
                instance = Activator.CreateInstance(types[token.ToString()]);
            }
            else
            {
                instance = Activator.CreateInstance(objectType);
            }
            serializer.Populate(reader, instance);
            return instance;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}