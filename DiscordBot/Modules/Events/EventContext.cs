using Discord;
using Discord.Commands;
using DiscordBot.Common;
using DiscordBot.Handler;
using System.Threading.Tasks;

namespace DiscordBot.Modules.Events
{
    public class EventContext
    {
        public Args Arguments;
        public SocketCommandContext ctx;
        public CommandHandler commandHandler;

        public IMessage Message;
        public IUser Author => ctx.Message.Author;
        public IMessageChannel Channel => ctx.Channel;
        public IGuild Guild => ctx.Guild;

        public async Task<IUser> GetCurrentUserAsync() => await Guild.GetCurrentUserAsync();
    }
}
