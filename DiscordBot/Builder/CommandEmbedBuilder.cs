using Discord;
using Discord.Commands;
using DiscordBot.Events;
using System;

namespace DiscordBot.Builder
{
    public class CommandEmbedBuilder
    {
        private EmbedBuilder _embed;
        private ImageEvents _image = new ImageEvents();
        private CommandEvents _cmd = new CommandEvents();

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

        public EmbedBuilder RolePlayEmbed(SocketCommandContext context, IUser user, string action, string bodyPart)
        {
            string image = _image.RolePlayImage(action, bodyPart);

            _embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} {action} {user.Username}'s {bodyPart}");
            if (Uri.IsWellFormedUriString(image, UriKind.Absolute)) { _embed.WithImageUrl(image); }

            return _embed;
        }

        public EmbedBuilder RolePlayEmbed(SocketCommandContext context, IUser user, string action)
        {
            string img = _image.RolePlayImage(action);

            if (user == null)
            {
                _embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} {action} everyone!");
            }
            else
            {
                _embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} {action} {user.Username}.");
            }

            if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }

            return _embed;
        }
    }
}
