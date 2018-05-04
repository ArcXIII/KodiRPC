using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Global
{
    public class Time
    {
        [JsonProperty(PropertyName = "hours", NullValueHandling = NullValueHandling.Ignore)]
        public int Hours { get; set; }

        [JsonProperty(PropertyName = "milliseconds", NullValueHandling = NullValueHandling.Ignore)]
        public int Milliseconds { get; set; }

        [JsonProperty(PropertyName = "minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int Minutes { get; set; }

        [JsonProperty(PropertyName = "seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int Seconds { get; set; }
    }
}