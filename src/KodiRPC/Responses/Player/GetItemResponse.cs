using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodiRPC.Responses.Types.List.Item;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Player
{
    public class GetItemResponse
    {
        [JsonProperty(PropertyName = "item")]
        public File Item { get; set; }
    }
}