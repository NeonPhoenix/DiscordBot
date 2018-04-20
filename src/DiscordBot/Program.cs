using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Init;
using DiscordBot.Utilities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace DiscordBot
{
    class Program
    {
        private static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();

        private static CommandService commands;
        private static DiscordSocketClient client;
        private static IServiceProvider services;

        public static DateTime timeSinceStartup;

        public async Task Start()
        {
            commands = new CommandService();
            client = new DiscordSocketClient();
            services = new ServiceCollection().BuildServiceProvider();

            timeSinceStartup = DateTime.Now;

            ImageInitialization.Init();
            Console.WriteLine("Initialization Finalised!");

            await InstallCommands();
            Console.WriteLine("Commands Installed!");

            await client.LoginAsync(TokenType.Bot, ConfigHandler.GetToken());
            await client.StartAsync();
            Console.WriteLine("Async Started!");

            await Task.Delay(-1);
        }

        public static async Task InstallCommands()
        {
            client.MessageReceived += HandleCommand;
            await commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }

        public static async Task HandleCommand(SocketMessage messageParam)
        {
            var message = messageParam as SocketUserMessage;
            int argPos = 0;
            if (message == null) return;
            if (!(message.HasCharPrefix('?', ref argPos) || message.HasMentionPrefix(client.CurrentUser, ref argPos))) return;
            var context = new SocketCommandContext(client, message);
            var result = await commands.ExecuteAsync(context, argPos, services);
            if (!result.IsSuccess) await context.Channel.SendMessageAsync(result.ErrorReason);
        }
    }
}
