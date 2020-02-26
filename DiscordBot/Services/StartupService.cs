using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Managers;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace DiscordBot.Services
{
    public class StartupService
    {
        private readonly DiscordSocketClient _discord;
        private readonly CommandService _commands;

        private readonly IServiceProvider _provider;
        private readonly IConfigurationRoot _config;

        public StartupService(DiscordSocketClient discord, CommandService commands, IServiceProvider provider, IConfigurationRoot config)
        {
            _discord = discord;
            _commands = commands;
            _provider = provider;
            _config = config;
        }

        public async Task StartAsync()
        {
            string discordToken = _config["DiscordToken"];

            await _discord.LoginAsync(TokenType.Bot, discordToken);
            await _discord.StartAsync();

            ConnectionManager.InitTimer();

            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _provider);
        }
    }
}
