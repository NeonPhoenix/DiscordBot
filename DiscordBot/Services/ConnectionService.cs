using Discord;
using Discord.WebSocket;
using System.Threading;
using System.Timers;

namespace DiscordBot.Services
{
    public class ConnectionService
    {
        private static DiscordSocketClient _discord;

        public static void InitTimer(DiscordSocketClient client)
        {
            _discord = client;

            System.Timers.Timer timer = new System.Timers.Timer(1000 * 60 * 1) { AutoReset = true };
            timer.Elapsed += CheckConnectionState;
            timer.Start();
        }

        private static void CheckConnectionState(object sender, ElapsedEventArgs e)
        {
            var state = _discord.ConnectionState.ToString();

            LoggingService.LogAsync(LogSeverity.Info, "Checking Current Connection State");

            Thread.Sleep(5);

            if(state == ConnectionState.Disconnected.ToString() || state == ConnectionState.Disconnecting.ToString())
            {
                LoggingService.LogAsync(LogSeverity.Info, $"Current Connection State: {state}");
                LoggingService.LogAsync(LogSeverity.Info, "Re-establishing Connection");
                _discord.StartAsync();
            }
            else
            {
                LoggingService.LogAsync(LogSeverity.Info, $"Current Connection State: {state}");
            }
        }
    }
}
