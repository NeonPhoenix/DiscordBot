using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Events;
using DiscordBot.Handlers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [ComVisible(false)]
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        [Command("kick")]
        [RequireUserPermission(GuildPermission.KickMembers)]
        public async Task Kick(SocketGuildUser usr, [Remainder]string name)
        {
            await ReplyAsync($"Goodbye {usr.Mention} :wave:");
            await usr.KickAsync();
        }

        [Group("precon")]
        [RequireUserPermission(GuildPermission.ManageGuild)]
        public class PreconRole : ModuleBase<SocketCommandContext>
        {
            [Command("add")]
            public async Task AddRolesToPreconditions(string precon, string roleName)
            {
                var result = await Task.Run(() => DatabaseHandler.CheckExistingPreconditionRole(Context.Guild.Id.ToString(), Context.Guild.Name.ToString(), precon, CommandEvents.GetMentionedRole(Context)));
                if (result.IsSuccess) { await ReplyAsync($"{roleName} successfully added to {precon}."); } else { await ReplyAsync(result.ToString()); }
            }

            [Command("remove")]
            public async Task RemoveRoleFromPrecondition(string precon, string roleName)
            {
                var result = await Task.Run(() => DatabaseHandler.RemoveExistingPreconditionRole(Context.Guild.Id.ToString(), Context.Guild.Name.ToString(), precon, CommandEvents.GetMentionedRole(Context)));
                if (result.IsSuccess) { await ReplyAsync($"{roleName} successfully removed from {precon}."); } else { await ReplyAsync(result.ToString()); }
            }
        }
    }
}
