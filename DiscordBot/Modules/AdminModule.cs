using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Managers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [ComVisible(false)]
    public class AdminModule : ModuleBase<SocketCommandContext>
    {
        [Command("kick")]
        [RequireUserPermission(GuildPermission.KickMembers)]
        public async Task Kick(SocketGuildUser usr, [Remainder] string name)
        {
            await ReplyAsync($"Goodbye {usr.Mention} :wave:");
            await usr.KickAsync();
        }

        [Command("prefix")]
        [RequireUserPermission(GuildPermission.ManageGuild)]
        public async Task PrefixAsync(string newPrefix)
        {
            DatabaseManager.ChangeGuildPrefix(Context.Guild.Id.ToString(), Context.Guild.Name.ToString(), newPrefix);
            await ReplyAsync($"Prefix has been changed to '{newPrefix}'");
        }

        [Group("module")]
        [RequireUserPermission(GuildPermission.ManageGuild)]
        public class ModuleStatus : ModuleBase<SocketCommandContext>
        {
            [Command("status")]
            public async Task ToggleAsync(string modName, bool modStatus)
            {
                var result = await Task.Run(() => DatabaseManager.ChangeModuleStatus(modName, Context.Guild.Id.ToString(), modStatus));
                if (result.IsSuccess)
                {
                    if (modStatus.Equals(false)) { await ReplyAsync($"{modName} has successfully been turned off."); }
                    else if (modStatus.Equals(true)) { await ReplyAsync($"{modName} has successfully been turned on."); }
                }
            }

            // TODO Add enable and disable module commands
        }

        [Command("autoassign")]
        [RequireUserPermission(GuildPermission.ManageGuild)]
        public async Task AutoAssignAsync(IRole roleName, bool active)
        {
            //DatabaseManager
            await ReplyAsync($"Role '{roleName.Name}' will be applied to new members.");
        }

        [Group("precon")]
        [RequireUserPermission(GuildPermission.ManageGuild)]
        public class PreconRole : ModuleBase<SocketCommandContext>
        {
            [Command("add")]
            public async Task AddRolesToPreconditions(string precon, IRole roleName)
            {
                var result = await Task.Run(() => DatabaseManager.AddPreconditionRole(Context, precon, roleName.Id));
                if (result.IsSuccess) { await ReplyAsync($"{roleName} successfully added to {precon}."); } else { await ReplyAsync(result.ToString()); }
            }

            [Command("remove")]
            public async Task RemoveRoleFromPrecondition(string precon, IRole roleName)
            {
                var result = await Task.Run(() => DatabaseManager.RemovePreconditionRole(Context, precon, roleName.Id));
                if (result.IsSuccess) { await ReplyAsync($"{roleName.Name} successfully removed from {precon} for {Context.Guild.Name}."); } else { await ReplyAsync(result.ToString()); }
            }

            [Command("assign")]
            public async Task AssignTextChannel(string precon, IRole role, IChannel channel)
            {
                var result = await Task.Run(() => DatabaseManager.AssignPreconditionToChannel(Context, precon, role.Id, channel.Id));
                if (result.IsSuccess) { await ReplyAsync($"{precon} has been successfully assigned to {Context.Message.MentionedChannels}."); } else { await ReplyAsync(result.ToString()); }
            }
        }
    }
}
