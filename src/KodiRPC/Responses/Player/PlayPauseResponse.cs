using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Player
{
    public class PlayPauseResponse
    {
        [JsonProperty(PropertyName = "speed")]
        public int Speed { get; set; }
    }
}