using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace DiscordBot.Modules
{
    [Group("admin")]
    public class AdminCommands
    {
        [Group("clean")]
        public class CleanModule : ModuleBase<SocketCommandContext>
        {
            [Command]
            public async Task Default(int count = 10) => Messages(count);

            [Command("messages")]
            public async Task Messages(int count = 10) { }
        }

        [Command("ban")]
        public async Task Ban(IGuildUser user)
        {

        }
    }
}
