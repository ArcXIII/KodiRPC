using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params.Player
{
    public class GetItemParams
    {
        [JsonProperty(PropertyName = "properties")]
        public string[] Properties { get; set; }

        [JsonProperty(PropertyName = "playerid")]
        public int PlayerId { get; set; }
    }
}