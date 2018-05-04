using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Player
{
    public class PlayerAudioStream
    {
        [JsonProperty(PropertyName = "bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int Bitrate { get; set; }

        [JsonProperty(PropertyName = "channels", NullValueHandling = NullValueHandling.Ignore)]
        public int Channels { get; set; }

        [JsonProperty(PropertyName = "codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }

        [JsonProperty(PropertyName = "index", NullValueHandling = NullValueHandling.Ignore)]
        public int Index { get; set; }

        [JsonProperty(PropertyName = "language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}