using Discord;
using Discord.Commands;
using DiscordBot.Modules.Events;
using System;

namespace DiscordBot.Modules.Builder
{
    public class CommandEmbedBuilder
    {
        private EmbedBuilder _embed;
        private ImageEvent _image = new ImageEvent();
        private CommandMessageEvent _cmd = new CommandMessageEvent();

        public EmbedBuilder ReactionEmbed(SocketCommandContext ctx, string action, string[] msg)
        {
            string mentioned = _cmd.GetMentionedUsername(ctx);
            string img = _image.ReactionImage(action);

            if (string.IsNullOrWhiteSpace(mentioned))
            {
                _embed = new EmbedBuilder().WithTitle($"{_cmd.GetAuthor(ctx)} {action} everyone! { _cmd.CleanMessage(ctx, msg)}");
            }
            else
            {
                _embed = new EmbedBuilder().WithTitle($"{_cmd.GetAuthor(ctx)} {action} {mentioned} {_cmd.CleanMessage(ctx, msg)}");
            }

            //262789836983762944
            if(ctx.User.Id == 262789836983762944)
            {
                if (Uri.IsWellFormedUriString("https://cdn.discordapp.com/attachments/454492932364435456/455878588672114699/scream.gif", UriKind.Absolute)) { _embed.WithImageUrl("https://cdn.discordapp.com/attachments/454492932364435456/455878588672114699/scream.gif"); }
            }
            else
            {
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            }
            
            return _embed;
        }

        public EmbedBuilder ReactionEmbed2(SocketCommandContext ctx, string action, string[] msg)
        {
            string img = _image.ReactionImage(action);

            _embed = new EmbedBuilder().WithTitle($"{_cmd.GetAuthor(ctx)} {action}! {_cmd.CleanMessage(ctx, msg)}");

            if (ctx.User.Id == 145333493742698496)
            {
                if (Uri.IsWellFormedUriString("https://cdn.discordapp.com/attachments/454492932364435456/455878588672114699/scream.gif", UriKind.Absolute)) { _embed.WithImageUrl("https://cdn.discordapp.com/attachments/454492932364435456/455878588672114699/scream.gif"); }
            }
            else
            {
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { _embed.WithImageUrl(img); }
            }

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
