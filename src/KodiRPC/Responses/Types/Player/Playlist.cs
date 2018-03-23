using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Player
{
    public class Playlist
    {
        [JsonProperty(PropertyName = "playlistid")]
        public int PlaylistId { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
