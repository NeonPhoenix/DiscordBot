using System;
using System.IO;
using Discord;

namespace DiscordBot.Utilities
{
    public class Reference
    {
        public string Token;

        public const string BotName = "NeonBot";
        public const string DatabaseCon = "";
        public const string Version = "0.0.1";

        public static string TokenFile = @"token.json";

        public static string FileLocation = Path.Combine(Environment.CurrentDirectory, @"config\", TokenFile);

        internal static Color OK_COLOR;
    }
}
