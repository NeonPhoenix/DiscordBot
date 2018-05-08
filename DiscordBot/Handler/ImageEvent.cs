using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace DiscordBot.Handler
{
    class ImageEvent
    {
        private static Random ran = new Random();

        string _reaction = @"Content\Reactions\_reactions.json";
        string _roleplay = @"Content\RolePlay\_roleplay.json";

        public string ReactionImage(string action)
        {
            JObject json = JObject.Parse(File.ReadAllText(_reaction));
            JObject items = (JObject)json[action];
            string img = (string)json[action][ran.Next(0, items.Count).ToString()];
            return img;
        }

        public string RolePlayImage(string action, string bodyPart)
        {
            JObject json = JObject.Parse(File.ReadAllText(_roleplay));
            JObject items = (JObject)json[action][bodyPart];
            string img = (string)json[action][bodyPart][ran.Next(0, items.Count).ToString()];
            return img;
        }

        public string RolePlayImage(string action)
        {
            JObject json = JObject.Parse(File.ReadAllText(_roleplay));
            JObject items = (JObject)json[action];
            string img = (string)json[action][ran.Next(0, items.Count).ToString()];
            return img;
        }
    }
}
