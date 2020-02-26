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

        public static EmbedBuilder ReactionEmbed(IGuildUser gUser, SocketGuildUser usr, string img, string action)
        {
            if (usr == null)
            {
                _embed = new EmbedBuilder().WithTitle($"{gUser.Nickname} {action} everyone!");
            }
            else
            {
                _embed = new EmbedBuilder().WithTitle($"{gUser.Nickname} {action} {usr.Nickname}");
            }

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            
            return _embed;
        }

        public static EmbedBuilder ReactionEmbed2(IGuildUser gUser, string img, string action)
        {
            _embed = new EmbedBuilder().WithTitle($"{gUser.Nickname} {action}!");

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }

            return _embed;
        }
    }
}
