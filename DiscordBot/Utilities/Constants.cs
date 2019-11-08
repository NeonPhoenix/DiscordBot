using System;

namespace DiscordBot.Utilities
{
    static class Constants
    {
        public static readonly string _lgPath = $@"{Environment.CurrentDirectory}\Content\Log\";
        public static readonly string _tkPath = $@"{Environment.CurrentDirectory}\Content\token.json";
        public static readonly string _dbPath = $@"{Environment.CurrentDirectory}\Content\roseDB.sqlite";

        public static readonly string _connectionString = $"Data Source={_dbPath};Version=3;";
    }
}
