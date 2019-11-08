using Discord.Commands;
using System.Collections.Generic;
using System.Linq;

namespace DiscordBot.Events
{
    public class CommandEvents
    {
        private static string RemoveStringFromString(string input, string charItem)
        {
            int indexOfChar = input.IndexOf(charItem);
            if(indexOfChar < 0) { return input; }
            return RemoveStringFromString(input.Remove(indexOfChar, 1), charItem);
        }

        public static string GetAuthor(SocketCommandContext ctx) { return ctx.Message.Author.Username; }

        public static string GetMentionedUsername(SocketCommandContext ctx)
        {
            IEnumerable<string> mentionedUser = ctx.Message.MentionedUsers.Select(x => x.Username);
            string user;
            
            if(mentionedUser.Count() > 1) { user = string.Join(" & ", mentionedUser); } else { user = string.Join(" ", mentionedUser); }

            return user;
        }

        public static string GetMentionedRole(SocketCommandContext ctx)
        {
            IEnumerable<string> mentionedRole = ctx.Message.MentionedRoles.Select(x => x.Name);

            string role = string.Join("", mentionedRole);

            return role;
        }

        public static string CleanMessage(SocketCommandContext ctx, string[] msg)
        {
            IEnumerable<string> mentionedUserId = ctx.Message.MentionedUsers.Select(x => x.Mention);

            string userId = string.Join(" ", mentionedUserId);
            string message = string.Join(" ", msg);

            if(string.IsNullOrWhiteSpace(userId))
            {
                return message;
            }
            else
            {
                userId = RemoveStringFromString(userId, "!");
                message = RemoveStringFromString(message, "!");
                message = message.Replace(userId, string.Empty);

                return message;
            }
        }
    }
}
