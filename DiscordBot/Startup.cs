using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Handlers;
using DiscordBot.Managers;
using DiscordBot.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set; }

        private protected Startup(string[] args)
        {
            StartupManager.CheckFiles();

            var builder = new ConfigurationBuilder().SetBasePath($@"{AppContext.BaseDirectory}\Content\").AddJsonFile("token.json");        
            Configuration = builder.Build();                
        }

        public static async Task RunAsync(string[] args)
        {
            var startup = new Startup(args);
            await startup.RunAsync().ConfigureAwait(false);
        }

        public async Task RunAsync()
        {
            var services = new ServiceCollection();         
            ConfigureServices(services);

            var provider = services.BuildServiceProvider();
            provider.GetRequiredService<LoggingService>();
            provider.GetRequiredService<DiscordEventHandler>();

            ConnectionManager.InitTimer();

            await provider.GetRequiredService<StartupService>().StartAsync();
            await Task.Delay(-1).ConfigureAwait(false);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(new DiscordSocketClient(new DiscordSocketConfig { LogLevel = LogSeverity.Verbose, MessageCacheSize = 1000 }))
                .AddSingleton(new CommandService(new CommandServiceConfig { LogLevel = LogSeverity.Verbose, DefaultRunMode = RunMode.Async, CaseSensitiveCommands = false }))
                .AddSingleton<LoggingService>()
                .AddSingleton<StartupService>()
                .AddSingleton<DiscordEventHandler>()
                .AddSingleton<Random>()
                .AddSingleton(Configuration);
        }
    }
}
