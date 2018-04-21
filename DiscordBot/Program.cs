using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Utilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    class Program
    {
        public static Task Main(string[] args) => Startup.RunAsync(args);
    }
}
