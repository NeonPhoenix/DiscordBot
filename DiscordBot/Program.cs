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
    class Program
    {
        static void Main() => new Program().MainAsync().GetAwaiter().GetResult();

        private static DiscordSocketClient _client;
        private static IConfiguration _config;

        public async Task MainAsync()
        {
            StartupManager.CheckFiles();
            
            _client = new DiscordSocketClient();
            _config = BuildConfig();
            
            var services = ConfigureServices();
            services.GetRequiredService<LoggingService>();
            await services.GetRequiredService<DiscordEventHandler>().InitializeAsync(services);

            await _client.LoginAsync(Discord.TokenType.Bot, _config["DiscordToken"]);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private static IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                // Base
                .AddSingleton(_client)
                .AddSingleton<CommandService>()
                .AddSingleton<DiscordEventHandler>()
                // Logging
                .AddSingleton<LoggingService>()
                // Extra
                .AddSingleton(_config)
                // Add additional services here
                .BuildServiceProvider();
        }

        private static IConfiguration BuildConfig()
        {
            return new ConfigurationBuilder()
                .SetBasePath($@"{AppContext.BaseDirectory}\Content\")
                .AddJsonFile("token.json")
                .Build();
        }
    }
}
