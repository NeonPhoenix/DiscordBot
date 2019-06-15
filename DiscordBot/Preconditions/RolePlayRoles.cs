using Discord;
using Discord.Commands;
using DiscordBot.Managers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBot.Preconditions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RolePlayRoles : PreconditionAttribute
    {
        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider service)
        {
            var channelID = DatabaseManager.CheckPreconditionChannel(context, "RolePlayRoles");
            var roleID = DatabaseManager.CheckPreconditionRole(context, "RolePlayRoles");

            if (!(context.User is IGuildUser user)) { return Task.FromResult(PreconditionResult.FromError("The command was not used in a guild!")); }

            if(!user.RoleIds.Contains(roleID))
            {
                if (!(0 == context.Channel.Id || channelID == context.Channel.Id))
                {
                    return Task.FromResult(PreconditionResult.FromError("You are not in the required channel for this command"));
                }

                return Task.FromResult(PreconditionResult.FromError("You do not have the required role to use this command!"));
            }

            return Task.FromResult(PreconditionResult.FromSuccess());
        }
    }
}
