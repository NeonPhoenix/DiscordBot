using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Services;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Handlers
{
    public class DiscordEventHandler
    {
        private readonly DiscordSocketClient _discord;
        private readonly CommandService _command;
        private readonly LoggingService _log;
        private readonly IServiceProvider _provider;

        public DiscordEventHandler(DiscordSocketClient client, CommandService command, LoggingService log, IServiceProvider provider)
        {
            _discord = client;
            _command = command;
            _log = log;
            _provider = provider;

            _discord.JoinedGuild += JoinedGuild;
            _discord.LeftGuild += LeftGuild;
            _discord.MessageReceived += OnMessageReceivedAsync;
        }

        private async Task JoinedGuild(SocketGuild guild)
        {
            var result = await Task.Run(() => DatabaseHandler.CheckGuild(guild.Id.ToString(), guild.Name));
            if(result.IsSuccess) { await LoggingService.LogAsync(LogSeverity.Info, $"Bot has joined {guild.Name} and has been assigned default prefix"); } else { await LoggingService.LogAsync(LogSeverity.Error, result.ToString()); }
        }

        private async Task LeftGuild(SocketGuild guild)
        {
            var result = await Task.Run(() => DatabaseHandler.RemoveGuild(guild.Id.ToString(), guild.Name));
            if (result.IsSuccess) { await LoggingService.LogAsync(LogSeverity.Info, $"Bot has been removed from {guild.Name}."); } else { await LoggingService.LogAsync(LogSeverity.Error, result.ToString()); }
        }

        private async Task OnMessageReceivedAsync(SocketMessage s)
        {
            if (!(s is SocketUserMessage msg)) return;
            if (msg.Author.Id == _discord.CurrentUser.Id) return;

            var context = new SocketCommandContext(_discord, msg);

            int argPos = 0;

            string prefix = "";
            string storedPrefix = DatabaseHandler.CheckGuildPrefix(context.Guild.Id.ToString());

            if (msg.Content.Contains(storedPrefix)) { prefix = storedPrefix; } else { prefix = storedPrefix.ToUpper(); }

            if (msg.HasStringPrefix(prefix, ref argPos) || msg.HasMentionPrefix(_discord.CurrentUser, ref argPos))
            {
                var result = await _command.ExecuteAsync(context, argPos, _provider);
                if (!result.IsSuccess) { await context.Channel.SendMessageAsync(result.ToString()); await LoggingService.LogAsync(LogSeverity.Info, result.ErrorReason.ToString()); }
            }
        }
    }
}
