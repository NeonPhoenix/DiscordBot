using Discord;
using Discord.Commands;
using System;

namespace DiscordBot.Events
{
    public class CommandEvent
    {
        private static EmbedBuilder embed;

        public static EmbedBuilder ReactionEmbed(SocketCommandContext context, IUser usr, string action, string img, string[] msg)
        {
            string temp = string.Join(" ", msg);

            if (usr == null)
            {
                embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} " + action + " everyone! " + temp);
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { embed.WithImageUrl(img); }
            }
            else
            {
                embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} " + action + $" {usr.Username} " + temp);
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { embed.WithImageUrl(img); }
            }

            return embed;
        }

        internal static object RolePlayEmbed(SocketCommandContext context, object p, string bodyPart, string img)
        {
            throw new NotImplementedException();
        }
    }
}
