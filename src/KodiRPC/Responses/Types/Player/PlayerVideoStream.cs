using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Player
{
    public class PlayerVideoStream
    {
        [JsonProperty(PropertyName = "codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }

        [JsonProperty(PropertyName = "height", NullValueHandling = NullValueHandling.Ignore)]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "index", NullValueHandling = NullValueHandling.Ignore)]
        public int Index { get; set; }

        [JsonProperty(PropertyName = "language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "width", NullValueHandling = NullValueHandling.Ignore)]
        public int Width { get; set; }
    }
}