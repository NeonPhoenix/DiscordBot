using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Events;
using System;

namespace DiscordBot.Builder
{
    public class CommandEmbedBuilder
    {
        private static EmbedBuilder _embed;

        public static EmbedBuilder ReactionEmbed(SocketCommandContext ctx, SocketGuildUser usr, string img, string action)
        {
            if (usr == null)
            {
                _embed = new EmbedBuilder().WithTitle($"{ctx.User.Username} {action} everyone!");
            }
            else
            {
                _embed = new EmbedBuilder().WithTitle($"{ctx.User.Username} {action} {usr.Username}");
            }

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }

            return _embed;
        }

        public static EmbedBuilder ReactionEmbed2(SocketCommandContext ctx, string img, string action)
        {
            _embed = new EmbedBuilder().WithTitle($"{ctx.User.Username} {action}!");

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }

            return _embed;
        }
    }
}
