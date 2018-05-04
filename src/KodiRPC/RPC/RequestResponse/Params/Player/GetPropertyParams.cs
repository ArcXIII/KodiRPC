using Newtonsoft.Json;

namespace KodiRPC.RPC.RequestResponse.Params.Player
{
    public class GetPropertyParams
    {
        [JsonProperty(PropertyName = "playerid")]
        public int PlayerId { get; set; }

        [JsonProperty(PropertyName = "properties")]
        public string[] Properties { get; set; }
    }
}