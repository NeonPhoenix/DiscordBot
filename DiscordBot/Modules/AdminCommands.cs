using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using DiscordBot.Init;

namespace DiscordBot.Modules
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        [Group("clean")]
        public class CleanModule
        {
            //[Command]
            //public async Task CleanDefaultAsync(int count = 10) => IMessage(count);

            [Command("messages")]
            public async Task CleanMessagesAsync(int count = 10) { }
        }

        [Command("ban")]
        public async Task BanAsync(IGuildUser user)
        {

        }

        [Command("reloadimages")]
        public async Task ReloadImageAsync()
        {
            ImageInitialization.ClearList();
            ImageInitialization.Init();
            await Context.Channel.SendMessageAsync("Reload Complete!");
        }
    }


}
