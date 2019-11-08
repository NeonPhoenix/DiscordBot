using System.Threading.Tasks;

namespace DiscordBot
{
    static class Program
    {
        public static Task Main(string[] args) => Startup.RunAsync(args);
    }
}
