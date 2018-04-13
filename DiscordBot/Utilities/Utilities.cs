using System;

namespace DiscordBot.Utilities
{
    public static class Utilities
    {
        public static DateTime UnixToDateTime(long unix)
        {
            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            time = time.AddSeconds(unix).ToLocalTime();
            return time;
        }

        public static float FromHoursToSeconds(this float value)
        {
            return (float)Math.Round(value * 60 * 60);
        }

        public static DateTime MinDbValue => new DateTime(1755, 1, 1, 0, 0, 0);

        public static bool CheckFirstRun()
        {
            return false;
        }

        public static void ReadFileToString()
        {
            
        }
    }
}
