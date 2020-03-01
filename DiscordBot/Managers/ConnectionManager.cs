using Discord;
using Discord.WebSocket;
using DiscordBot.Services;
using System;
using System.Timers;

namespace DiscordBot.Managers
{
    static class ConnectionManager
    {
        private static readonly DiscordSocketClient _discord;

        public static void InitTimer()
        {
            Timer timer = new Timer(1000 * 60 * 5) { AutoReset = true };
            timer.Elapsed += CheckConnectionState;
            timer.Start();
        }

        private static void CheckConnectionState(object sender, ElapsedEventArgs e)
        {
            var state = _discord.ConnectionState.ToString();

            LoggingService.LogAsync(LogSeverity.Info, $"Current Connection State: {state}");
            LoggingService.LogAsync(LogSeverity.Info, "Restarting Application");
        }
    }
}
