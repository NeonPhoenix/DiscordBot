using Discord;
using DiscordBot.Services;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DiscordBot.Objects
{
    public class Manifest
    {
        private string _data;
        private string _className = "Mainfest";

        public int Version { get; set; }
        public int CheckInterval { get; set; }
        public string RemoteConfigURI { get; set; }
        public string SecurityToken { get; set; }
        public string BaseURI { get; set; }
        public string[] Payloads { get; set; }

        public Manifest(string data)
        {
            Load(data);
        }

        private void Load(string data)
        {
            _data = data;

            try
            {
                var xml = XDocument.Parse(data);

                if (xml.Root.Name.LocalName != "Manifest")
                {
                    LoggingService.LogAsync(LogSeverity.Warning, _className, $"Root XML element '{xml.Root.Name}' is not recognized, stopping.");
                    return;
                }

                Version = int.Parse(xml.Root.Attribute("version").Value);
                CheckInterval = int.Parse(xml.Root.Element("CheckInterval").Value);
                SecurityToken = xml.Root.Element("SecurityToken").Value;
                RemoteConfigURI = xml.Root.Element("RemoteConfigURI").Value;
                BaseURI = xml.Root.Element("BaseURI").Value;
                Payloads = xml.Root.Elements("Payload").Select(x => x.Value).ToArray();
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
        }

        public void Write(string path)
        {
            File.WriteAllText(path, _data);
        }
    }
}
