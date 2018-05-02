using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;

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
    }
}
