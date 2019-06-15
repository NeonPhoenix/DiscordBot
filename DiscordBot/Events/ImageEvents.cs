using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace DiscordBot.Events
{
    class ImageEvents
    {
        private static Random ran = new Random();

        readonly string _reaction = @"Content\Images\_reactions.json";
        readonly string _roleplay = @"Content\Images\_roleplay.json";

        public string ReactionImage(string action)
        {
            JObject json = JObject.Parse(File.ReadAllText(_reaction));
            JObject items = (JObject)json[action];
            string img = (string)json[action][ran.Next(0, items.Count).ToString()];
            return img;
        }

        public string RolePlayImage(string action)
        {
            JObject json = JObject.Parse(File.ReadAllText(_roleplay));
            JObject items = (JObject)json[action];
            string img = (string)json[action][ran.Next(0, items.Count).ToString()];
            return img;
        }

        //TODO Find a way to have nested array in json for roleplay
    }
}
