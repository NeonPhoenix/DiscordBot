using Discord;
using DiscordBot.Services;
using DiscordBot.Utilities;
using Newtonsoft.Json;
using System;
using System.Data.SQLite;
using System.IO;

namespace DiscordBot.Managers
{
    static class StartupManager
    {
        private const string _className = "StartupManager";

        public static void CheckFiles()
        {
            if(!File.Exists(Constants._tkPath)) { CreateSettingsJSON(); }
            if(!File.Exists(Constants._dbPath)) { CreateSQLDatabase(); }
        }

        private static void CreateSettingsJSON()
        {
            LoggingService.LogAsync(LogSeverity.Warning, _className, "No token file was detected. Creating new file...");
            LoggingService.LogAsync(LogSeverity.Warning, _className, "Please paste your unique discord token below: ");
            var userInput = Console.ReadLine();

            Token tk = new Token { DiscordToken = userInput };  

            try
            {
                File.WriteAllText(Constants._tkPath, JsonConvert.SerializeObject(tk));
                LoggingService.LogAsync(LogSeverity.Info, _className, "New token file has been created.");
            }
            catch (IOException ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
        }

        private static void CreateSQLDatabase()
        {
            LoggingService.LogAsync(LogSeverity.Warning, _className, "No database file was detected, creating new file...");

            try
            {
                SQLiteConnection.CreateFile(Constants._dbPath);
                LoggingService.LogAsync(LogSeverity.Info, _className, "New database was created successfully.");

                DatabaseManager.CreateGuildTable();
                DatabaseManager.CreateUserTable();
                DatabaseManager.CreatePreconTable();
            }
            catch(Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
        }
    }

    public class Token
    {
        public string DiscordToken { get; set; }
    }
}
