using Discord;
using Discord.WebSocket;
using DiscordBot.Services;
using System.Timers;

namespace DiscordBot.Managers
{
    public class ConnectionManager
    {
        private static DiscordSocketClient _discord;

        public static void InitTimer(DiscordSocketClient client)
        {
            _discord = client;

            Timer timer = new Timer(1000 * 60 * 5) { AutoReset = true };
            timer.Elapsed += CheckConnectionState;
            timer.Start();
        }

        private static void CheckConnectionState(object sender, ElapsedEventArgs e)
        { 
            var state = _discord.ConnectionState.ToString();

            if(state == ConnectionState.Disconnected.ToString() || state == ConnectionState.Disconnecting.ToString())
            {
                LoggingService.LogAsync(LogSeverity.Info, $"Current Connection State: {state}");
                LoggingService.LogAsync(LogSeverity.Info, "Restarting Application");

                UpdateManager.RestartProgram();
            }
        }
    }
}
