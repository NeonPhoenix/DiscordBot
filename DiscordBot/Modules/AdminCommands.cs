using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Init;

namespace DiscordBot.Modules
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        [Command("kick")]
        [RequireUserPermission(GuildPermission.KickMembers)]
        public async Task Kick(SocketGuildUser usr, [Remainder]string name)
        {
            await ReplyAsync($"Goodbye {usr.Mention} :wave:");
            await usr.KickAsync();
        }

        [Command("reloadimages")]
        [Summary("Reload Image list for SFW and NSFW Commands.")]
        [RequireUserPermission(GuildPermission.ManageChannels)]
        public async Task ReloadImage()
        {
            ImageInitialization.Clear();
            ImageInitialization.Init();
            await Context.Channel.SendMessageAsync("Reload Complete!");
        }
    }
}
