using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Events;
using System;

namespace DiscordBot.Builder
{
    public class CommandEmbedBuilder
    {
        public static EmbedBuilder ReactionEmbed(IGuildUser gUser, string img, string action)
        {
            EmbedBuilder _embed = new EmbedBuilder().WithTitle($"{gUser.Nickname} {action} everyone!");

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }

            return _embed;
        }

        public static EmbedBuilder ReactionEmbedMention(IGuildUser gUser, SocketGuildUser usr, string img, string action)
        {
            EmbedBuilder _embed = new EmbedBuilder().WithTitle($"{gUser.Nickname} {action} {usr.Nickname}");

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            
            return _embed;
        }

        public static EmbedBuilder ReactionEmbed2(IGuildUser gUser, string img, string action)
        {
            EmbedBuilder _embed = new EmbedBuilder().WithTitle($"{gUser.Nickname} {action}!");

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }

            return _embed;
        }
    }
}
