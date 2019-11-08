using Discord;
using DiscordBot.Services;
using System.Diagnostics;
using System.Threading;

namespace DiscordBot.Managers
{
    //TODO IMPLEMENT UPDATE CHECK
    //TODO IMPLEMENT UPGRADE
    //TODO IMPLEMENT UPDATE GRAB

    static class UpdateManager
    {
        private static Timer _timer;
        private static Process _process = Process.GetCurrentProcess();

        private static int DefaultCheckInterval = 900;

        private static string _className = "UpdateManager";
        private static string _program = _process.MainModule.FileName.ToString();

        public static void StartMonitoring()
        {
            LoggingService.LogAsync(LogSeverity.Info, _className, $"Starting to monitor for new updates every {DefaultCheckInterval}s.");
            //_timer = new Timer(CheckForUpdate, null, 5000, DefaultCheckInterval);
        }

        public static void StopMonitoring()
        {
            LoggingService.LogAsync(LogSeverity.Info, _className, "Stopping to monitor for new updates.");

            if(_timer == null) { LoggingService.LogAsync(LogSeverity.Info, _className, "Monitor was already stopped."); return; }

            _timer.Dispose();
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
