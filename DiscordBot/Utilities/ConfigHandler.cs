using System.IO;
using Newtonsoft.Json;

namespace DiscordBot.Utilities
{
    class ConfigHandler
    {
        private static string _file = @"token.json";

        public static string GetToken()
        {
            TokenFile tkn = JsonConvert.DeserializeObject<TokenFile>(File.ReadAllText(_file));

            return tkn.Token;
        }
    }

    public class TokenFile
    {
        public string Token;
    }
}
