using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace DiscordBot.Events
{
    class ImageEvents
    {
        private static Random ran = new Random();

        readonly string _reaction = @"Content\Images\_reactions.json";

        public string ReactionImage(string action)
        {
            JObject json = JObject.Parse(File.ReadAllText(_reaction));
            JObject items = (JObject)json[action];
            string img = (string)json[action][ran.Next(0, items.Count).ToString()];
            return img;
        }

        //TODO Remove smaller images and replace with larger ones
        //TODO Add more images to groove command
    }
}
