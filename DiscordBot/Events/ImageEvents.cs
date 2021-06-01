using DiscordBot.API;
using DiscordBot.Objects;
using DiscordBot.Utilities;
using Newtonsoft.Json;
using System;
using System.IO;

namespace DiscordBot.Events
{
    class ImageEvents
    {
        private static readonly Random ran = new Random();

        public static string ReactionImage(String command)
        {
            TokenObject apikey = JsonConvert.DeserializeObject<TokenObject>(File.ReadAllText(Constants._tkPath));
            GifObject rObject = Tenor.GetSearchData(String.Format("anime {0}", command), apikey.TenorToken, 5);
            return rObject.results[ran.Next(0, rObject.results.Count)].media[0].gif.url;
        }
    }
}
