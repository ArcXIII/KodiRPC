using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Playlist
{
    public class GetPlaylistsResponse
    {
        [JsonProperty("items")]
        public List<Types.Player.Playlist> Items { get; set; }
    }
}
