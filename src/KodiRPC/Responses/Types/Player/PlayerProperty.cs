using KodiRPC.Responses.Types.Global;
using Newtonsoft.Json;

namespace KodiRPC.Responses.Types.Player
{
    // Player properties and response for Player.GetProperties
    public class PlayerProperty
    {
        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "partymode", NullValueHandling = NullValueHandling.Ignore)]
        public bool Partymode { get; set; }

        [JsonProperty(PropertyName = "speed", NullValueHandling = NullValueHandling.Ignore)]
        public int Speed { get; set; }

        [JsonProperty(PropertyName = "time", NullValueHandling = NullValueHandling.Ignore)]
        public Time Time { get; set; }

        [JsonProperty(PropertyName = "percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double Percentage { get; set; }

        [JsonProperty(PropertyName = "totaltime", NullValueHandling = NullValueHandling.Ignore)]
        public Time Totaltime { get; set; }

        [JsonProperty(PropertyName = "playlistid", NullValueHandling = NullValueHandling.Ignore)]
        public int Playlistid { get; set; }

        [JsonProperty(PropertyName = "position", NullValueHandling = NullValueHandling.Ignore)]
        public int Position { get; set; }

        [JsonProperty(PropertyName = "repeat", NullValueHandling = NullValueHandling.Ignore)]
        public string Repeat { get; set; }

        [JsonProperty(PropertyName = "shuffled", NullValueHandling = NullValueHandling.Ignore)]
        public bool Shuffled { get; set; }

        [JsonProperty(PropertyName = "canseek", NullValueHandling = NullValueHandling.Ignore)]
        public bool Canseek { get; set; }

        [JsonProperty(PropertyName = "canchangespeed", NullValueHandling = NullValueHandling.Ignore)]
        public bool Canchangespeed { get; set; }

        [JsonProperty(PropertyName = "canmove", NullValueHandling = NullValueHandling.Ignore)]
        public bool Canmove { get; set; }

        [JsonProperty(PropertyName = "canzoom", NullValueHandling = NullValueHandling.Ignore)]
        public bool Canzoom { get; set; }

        [JsonProperty(PropertyName = "canrotate", NullValueHandling = NullValueHandling.Ignore)]
        public bool Canrotate { get; set; }

        [JsonProperty(PropertyName = "canshuffle", NullValueHandling = NullValueHandling.Ignore)]
        public bool Canshuffle { get; set; }

        [JsonProperty(PropertyName = "canrepeat", NullValueHandling = NullValueHandling.Ignore)]
        public bool Canrepeat { get; set; }

        [JsonProperty(PropertyName = "currentaudiostream", NullValueHandling = NullValueHandling.Ignore)]
        public PlayerAudioStream Currentaudiostream { get; set; }

        [JsonProperty(PropertyName = "audiostreams", NullValueHandling = NullValueHandling.Ignore)]
        public PlayerAudioStream[] Audiostreams { get; set; }

        [JsonProperty(PropertyName = "subtitleenabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool Subtitleenabled { get; set; }

        [JsonProperty(PropertyName = "currentsubtitle", NullValueHandling = NullValueHandling.Ignore)]
        public Subtitle Currentsubtitle { get; set; }

        [JsonProperty(PropertyName = "subtitles", NullValueHandling = NullValueHandling.Ignore)]
        public Subtitle[] Subtitles { get; set; }

        [JsonProperty(PropertyName = "live", NullValueHandling = NullValueHandling.Ignore)]
        public bool Live { get; set; }

        [JsonProperty(PropertyName = "currentvideostream", NullValueHandling = NullValueHandling.Ignore)]
        public PlayerVideoStream Currentvideostream { get; set; }

        [JsonProperty(PropertyName = "videostreams", NullValueHandling = NullValueHandling.Ignore)]
        public PlayerVideoStream[] Videostreams { get; set; }
    }
}