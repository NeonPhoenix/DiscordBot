﻿using Discord;
using Discord.Commands;
using Discord.WebSocket;
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
        private readonly IConfigurationRoot _config;

        public StartupService(DiscordSocketClient discord, CommandService commands, IConfigurationRoot config)
        {
            _config = config;
            _discord = discord;
            _commands = commands;
        }

        public async Task StartAsync()
        {
            string discordToken = _config["Tokens:Discord"];
            if (string.IsNullOrWhiteSpace(discordToken))
                throw new Exception("Please enter your bot's token into the '_configuration.json' file found in the applications root directory!");

            await _discord.LoginAsync(TokenType.Bot, discordToken);
            await _discord.StartAsync();

            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }
    }
}
