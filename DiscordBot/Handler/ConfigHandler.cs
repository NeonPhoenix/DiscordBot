using System;
using System.IO;
using Newtonsoft.Json;

namespace DiscordBot.Utilities
{
    public class ConfigHandler
    {
        public static string GetToken()
        {
            //Reference tkn = JsonConvert.DeserializeObject<Reference>(File.ReadAllText(Reference.FileLocation));
            Reference tkn = JsonConvert.DeserializeObject<Reference>(File.ReadAllText(Reference.TokenFile));

            return tkn.Token;
        }

        internal static int GetShardCount()
        {
            throw new NotImplementedException();
        }

        internal static string GetDefaultLangauge()
        {
            throw new NotImplementedException();
        }
    }
}
