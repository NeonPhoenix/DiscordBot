using Discord;
using DiscordBot.Services;
using System.Diagnostics;
using System.Threading;

namespace DiscordBot.Managers
{
    static class UpdateManager
    {
        private static Process _process = Process.GetCurrentProcess();

        private static int DefaultCheckInterval = 900;

        private static string _className = "UpdateManager";
        private static string _program = _process.MainModule.FileName.ToString();

        public static void StartMonitoring()
        {
            LoggingService.LogAsync(LogSeverity.Info, _className, $"Starting to monitor for new updates every {DefaultCheckInterval}s.");
        }

        public static void StopMonitoring()
        {
            LoggingService.LogAsync(LogSeverity.Info, _className, "Stopping to monitor for new updates.");
        }

        public static void RestartProgram()
        {
            LoggingService.LogAsync(LogSeverity.Info, _className, "Program restarting. Spawning new process...");

            var spawn = Process.Start(_program);

            LoggingService.LogAsync(LogSeverity.Info, _className, $"Program restarting. New process is '{spawn.Id}'!");
            LoggingService.LogAsync(LogSeverity.Info, _className, $"Program restarting. Clossing current running process '{_process.Id}'!");

            _process.CloseMainWindow();
            _process.Close();
            _process.Dispose();
        }
    }
}
