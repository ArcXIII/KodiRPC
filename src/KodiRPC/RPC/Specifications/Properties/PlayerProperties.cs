using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KodiRPC.RPC.Specifications.Properties
{
    public class PlayerProperties
    {
        public const string Type = "type";
        public const string Partymode = "partymode";
        public const string Speed = "speed";
        public const string Time = "time";
        public const string Percentage = "percentage";
        public const string Totaltime = "totaltime";
        public const string Playlistid = "playlistid";
        public const string Position = "position";
        public const string Repeat = "repeat";
        public const string Shuffled = "shuffled";
        public const string Canseek = "canseek";
        public const string Canchangespeed = "canchangespeed";
        public const string Canmove = "canmove";
        public const string Canzoom = "canzoom";
        public const string Canrotate = "canrotate";
        public const string Canshuffle = "canshuffle";
        public const string Canrepeat = "canrepeat";
        public const string Currentaudiostream = "currentaudiostream";
        public const string Audiostreams = "audiostreams";
        public const string Subtitleenabled = "subtitleenabled";
        public const string Currentsubtitle = "currentsubtitle";
        public const string Subtitles = "subtitles";
        public const string Live = "live";
        public const string Currentvideostream = "currentvideostream";
        public const string Videostreams = "videostreams";

        public static string[] All()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;

            return declaringType?.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Select(field => field.GetValue(null) as string).ToArray();
        }
    }
}