using System;

namespace DiscordBot.Utilities
{
    public class Constants
    {
        private static string _dbPath = Environment.CurrentDirectory + @"\Database\aphrodite_rose.accdb";

        public static string _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _dbPath;
    }
}
