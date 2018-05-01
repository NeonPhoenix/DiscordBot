using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Events
{
    public class CommandEvent
    {
        private static EmbedBuilder embed;

        public static EmbedBuilder Embed(SocketCommandContext context, IUser usr, string action, string img, string[] msg)
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
    }
}
