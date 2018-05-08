using Discord;
using Discord.Commands;
using DiscordBot.Events;
using DiscordBot.Handler;
using System;

namespace DiscordBot.Builder
{
    public class CommandEmbedBuilder
    {
        private EmbedBuilder _embed;
        private ImageEvent _image = new ImageEvent();
        private CommandMessageEvent _cmd = new CommandMessageEvent();

        public EmbedBuilder ReactionEmbed(SocketCommandContext ctx, string action, string[] msg)
        {
            string mentioned = _cmd.GetMentionedUsername(ctx);
            string message = _cmd.CleanMessage(ctx, msg);
            string img = _image.ReactionImage(action);

            if(string.IsNullOrWhiteSpace(mentioned))
            {
                _embed = new EmbedBuilder().WithTitle($"{ctx.Message.Author.Username} " + action + " everyone! " + message);
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            }
            else
            {
                _embed = new EmbedBuilder().WithTitle($"{ctx.Message.Author.Username} " + action + $" {mentioned} " + message);
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            }
            
            return _embed;
        }

        public EmbedBuilder RolePlayEmbed(SocketCommandContext context, IUser user, string action, string bodyPart)
        {
            _embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} " + action + $" {user.Username}'s " + bodyPart);
            string image = _image.RolePlayImage(action, bodyPart);
            if (Uri.IsWellFormedUriString(image, UriKind.Absolute)) { _embed.WithImageUrl(image); }
            return _embed;
        }

        public EmbedBuilder RolePlayEmbed(SocketCommandContext context, IUser user, string action)
        {
            string img = _image.RolePlayImage(action);

            if (user == null)
            {
                _embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} " + action + " everyone! ");
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            }
            else
            {
                _embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} " + action + $" {user.Username}.");
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            }

            return _embed;
        }
    }
}
