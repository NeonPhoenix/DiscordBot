using Discord.Commands;
using System.Collections.Generic;
using System.Linq;

namespace DiscordBot.Events
{
    public class CommandMessageEvent
    {
        private string RemoveStringFromString(string input, string charItem)
        {
            var indexOfChar = input.IndexOf(charItem);
            if(indexOfChar < 0) { return input; }
            return RemoveStringFromString(input.Remove(indexOfChar, 1), charItem);
        }

        private List<string> AddStringToString(List<string> input, char charItem)
        {
            List<string> output = new List<string>();
            string[] tempArray;
            string temp;

            for (int i = 0; i < input.Count(); i++)
            {
                tempArray = input[i].Split(charItem);
                temp = $"{tempArray[0]}@!{tempArray[1]}";
                output.Add(temp);
            }

            return output;
        }

        public string GetAuthor(SocketCommandContext ctx) { return ctx.Message.Author.Username; }

        public string GetMentionedUsername(SocketCommandContext ctx)
        {
            IEnumerable<string> mentionedUser = ctx.Message.MentionedUsers.Select(x => x.Username);
            List<string> user = new List<string>();
            string joined;

            if(mentionedUser.Count() > 1)
            {
                for(int i = 0; i < mentionedUser.Count(); i++)
                {
                    user.Add(mentionedUser.ToString());
                }
            }
            
            if(mentionedUser.Count() > 1) { joined = string.Join(" & ", user); } else { joined = string.Join(" ", user); }

            return joined;
        }

        public string CleanMessage(SocketCommandContext ctx, string[] msg)
        {
            IEnumerable<string> mentionedUserId = ctx.Message.MentionedUsers.Select(x => x.Mention);

            List<string> userId = new List<string>();
            string message = string.Join(" ", msg);

            for(int i = 0; i < mentionedUserId.Count(); i++)
            {
                userId.Add(mentionedUserId.ToString());
            }

            if(userId.Count == 0)
            {
                return message;
            }
            else
            {
                userId = AddStringToString(userId, '@');

                for(int a = 0; a < userId.Count(); a++)
                {
                    message = RemoveStringFromString(userId[a], string.Empty);
                }

                //message = message.Replace(userId, string.Empty);
                return message;
            }
        }
    }
}
