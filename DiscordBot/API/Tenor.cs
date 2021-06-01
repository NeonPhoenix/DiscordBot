using System;
using System.Net;
using DiscordBot.Objects;
using Newtonsoft.Json;

namespace DiscordBot.API
{
    class Tenor
    {
        public static GifObject GetSearchData(String searchTerm, String apiKey, int limit)
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;

                try
                {
                    json_data = w.DownloadString(GetSearchResult(searchTerm, apiKey, limit));
                }
                catch (Exception e)
                {

                }

                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<GifObject>(json_data) : new GifObject();
            }

        }

        private static String GetSearchResult(String searchTerm, String apiKey, int limit)
        {
            return String.Format("https://g.tenor.com/v1/random?q={0}&key={1}&limit={2}", searchTerm, apiKey, limit);
        }
    }
}
