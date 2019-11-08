using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Managers;
using DiscordBot.Services;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Handlers
{
    public class DiscordEventHandler
    {
        private static DiscordSocketClient _discord;
        private static CommandService _command;
        private static IServiceProvider _provider;

        public DiscordEventHandler(DiscordSocketClient client, CommandService command, IServiceProvider provider)
        {
            _discord = client;
            _command = command;
            _provider = provider;

            _discord.JoinedGuild += JoinedGuild;
            _discord.LeftGuild += LeftGuild;
            _discord.MessageReceived += OnMessageReceivedAsync;
        }

        private static async Task JoinedGuild(SocketGuild guild)
        {
            var result = await Task.Run(() => DatabaseManager.CheckGuild(guild.Id.ToString(), guild.Name));

            if (result.IsSuccess)
            {
                await LoggingService.LogAsync(LogSeverity.Info, $"Bot has joined {guild.Name} and has been assigned default prefix");
            }
            else
            {
                await LoggingService.LogAsync(LogSeverity.Error, result.ToString());
            }
        }

        private static async Task LeftGuild(SocketGuild guild)
        {
            var result = await Task.Run(() => DatabaseManager.RemoveGuild(guild.Id.ToString(), guild.Name));

            if (result.IsSuccess)
            {
                await LoggingService.LogAsync(LogSeverity.Info, $"Bot has been removed from {guild.Name}.");
            }
            else
            {
                await LoggingService.LogAsync(LogSeverity.Error, result.ToString());
            }
        }

        private static async Task OnMessageReceivedAsync(SocketMessage s)
        {
            if (!(s is SocketUserMessage msg)) { return; }
            if (msg.Author.Id == _discord.CurrentUser.Id) { return; }

            var context = new SocketCommandContext(_discord, msg);

            int argPos = 0;

            string prefix = "";
            string storedPrefix = DatabaseManager.CheckGuildPrefix(context.Guild.Id.ToString());

            if (msg.Content.Contains(storedPrefix)) { prefix = storedPrefix.ToLowerInvariant(); } else { prefix = storedPrefix.ToUpperInvariant(); }

            if (msg.HasStringPrefix(prefix, ref argPos) || msg.HasMentionPrefix(_discord.CurrentUser, ref argPos))
            {
                var result = await _command.ExecuteAsync(context, argPos, _provider);
                if (!result.IsSuccess)
                {
                    await context.Channel.SendMessageAsync(result.ToString());
                    await LoggingService.LogAsync(LogSeverity.Info, result.ErrorReason.ToString());
                }
            }
        }
    }
}
