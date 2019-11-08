using Discord;
using Discord.Commands;
using DiscordBot.Events;
using System;

namespace DiscordBot.Builder
{
    public class CommandEmbedBuilder
    {
        private EmbedBuilder _embed;
        private readonly ImageEvents _image = new ImageEvents();
        private readonly CommandEvents _cmd = new CommandEvents();

        public EmbedBuilder ReactionEmbed(SocketCommandContext ctx, string action, string[] msg)
        {
            string mentioned = _cmd.GetMentionedUsername(ctx);
            string img = _image.ReactionImage(action);

            if (string.IsNullOrWhiteSpace(mentioned))
            {
                _embed = new EmbedBuilder().WithTitle($"{_cmd.GetAuthor(ctx)} {action} everyone! {_cmd.CleanMessage(ctx, msg)}");
            }
            else
            {
                _embed = new EmbedBuilder().WithTitle($"{_cmd.GetAuthor(ctx)} {action} {mentioned} {_cmd.CleanMessage(ctx, msg)}");
            }

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            
            return _embed;
        }

        public EmbedBuilder ReactionEmbed2(SocketCommandContext ctx, string action, string[] msg)
        {
            string img = _image.ReactionImage(action);

            _embed = new EmbedBuilder().WithTitle($"{_cmd.GetAuthor(ctx)} {action}! {_cmd.CleanMessage(ctx, msg)}");

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }

            return _embed; 
        }
    }
}
