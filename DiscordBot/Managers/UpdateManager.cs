using Discord;
using DiscordBot.Objects;
using DiscordBot.Services;
using System;
using System.Diagnostics;
using System.Threading;

namespace DiscordBot.Managers
{
    public class UpdateManager
    {
        private static Timer _timer;
        private static Process _process = Process.GetCurrentProcess();

        private static readonly Manifest _localConfig;
        private static Manifest _remoteConfig;

        private static int DefaultCheckInterval = 900;

        private static string _className = "UpdateManager";
        private static string _program = _process.MainModule.FileName.ToString();

        private static volatile bool _updating;

        public static void StartMonitoring()
        {
            LoggingService.LogAsync(LogSeverity.Info, _className, $"Starting to monitor for new updates every {DefaultCheckInterval}s.");
            _timer = new Timer(CheckForUpdate, null, 5000, DefaultCheckInterval);
        }

        public static void StopMonitoring()
        {
            LoggingService.LogAsync(LogSeverity.Info, _className, "Stopping to monitor for new updates.");

            if(_timer == null) { LoggingService.LogAsync(LogSeverity.Info, _className, "Monitor was already stopped."); return; }

            _timer.Dispose();
        }

        private static void CheckForUpdate(object state)
        {
            //TODO IMPLEMENT UPDATE CHECK
        }

        private static void UpdateToNewVersion()
        {
            //TODO IMPLEMENT UPGRADE
        }

        private static void FetchUpdate()
        {
            //TODO IMPLEMENT UPDATE GRAB
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
