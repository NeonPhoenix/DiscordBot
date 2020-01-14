using Discord;
using Discord.Commands;
using DiscordBot.Events;
using System;

namespace DiscordBot.Builder
{
    public class CommandEmbedBuilder
    {
        private static EmbedBuilder _embed;

        public static EmbedBuilder ReactionEmbed(SocketCommandContext ctx, string img, string action, string[] msg)
        {
            string mentioned = CommandEvents.GetMentionedUsername(ctx);

            if (string.IsNullOrWhiteSpace(mentioned))
            {
                _embed = new EmbedBuilder().WithTitle($"{CommandEvents.GetAuthor(ctx)} {action} everyone! {CommandEvents.CleanMessage(ctx, msg)}");
            }
            else
            {
                _embed = new EmbedBuilder().WithTitle($"{CommandEvents.GetAuthor(ctx)} {action} {mentioned} {CommandEvents.CleanMessage(ctx, msg)}");
            }

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            
            return _embed;
        }

        public static EmbedBuilder ReactionEmbed2(SocketCommandContext ctx, string img, string action, string[] msg)
        {
            _embed = new EmbedBuilder().WithTitle($"{CommandEvents.GetAuthor(ctx)} {action}! {CommandEvents.CleanMessage(ctx, msg)}");

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }

            return _embed;
        }
    }
}
