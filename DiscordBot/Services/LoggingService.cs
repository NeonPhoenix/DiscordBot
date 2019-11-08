using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Utilities;
using System;
using System.IO;
using System.Threading.Tasks;

namespace DiscordBot.Services
{
    public class LoggingService
    {
        private static string _logFile => Path.Combine(Constants._lgPath, $"{DateTime.UtcNow.ToString("yyyy-MM-dd")}.txt");

        public LoggingService(DiscordSocketClient discord, CommandService commands)
        {
            DiscordSocketClient _discord = discord;
            CommandService _commands = commands;

            _discord.Log += OnLogAsync;
            _commands.Log += OnLogAsync;
        }

        private static void CheckFiles()
        {
            if (!Directory.Exists(Constants._lgPath)) { Directory.CreateDirectory(Constants._lgPath); }
            if (!File.Exists(_logFile)) { File.Create(_logFile).Dispose(); }
        }

        private static Task OnLogAsync(LogMessage msg)
        {
            CheckFiles();

            string logText = $"{DateTime.UtcNow.ToString("hh:mm:ss")} [{msg.Severity}] {msg.Source}: {msg.Exception?.ToString() ?? msg.Message}";
            File.AppendAllText(_logFile, logText + "\n");

            return Console.Out.WriteLineAsync(logText);
        }

        public static Task LogAsync(LogSeverity sev, string message)
        {
            CheckFiles();

            string logText = $"{DateTime.UtcNow.ToString("hh:mm:ss")} [{sev}] {message}";
            File.AppendAllText(_logFile, logText + "\n");

            return Console.Out.WriteLineAsync(logText);
        }

        public static Task LogAsync(LogSeverity sev, string source, string message)
        {
            CheckFiles();

            string logText = $"{DateTime.UtcNow.ToString("hh:mm:ss")} [{sev}] {source}: {message}";
            File.AppendAllText(_logFile, logText + "\n");

            return Console.Out.WriteLineAsync(logText);
        }
    }
}
