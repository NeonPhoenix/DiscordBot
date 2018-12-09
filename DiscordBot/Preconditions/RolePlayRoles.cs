using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Handlers;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBot.Preconditions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RolePlayRoles : PreconditionAttribute
    {
        public override Task<PreconditionResult> CheckPermissions(ICommandContext context, CommandInfo command, IServiceProvider service)
        {
            ArrayList roleNames = DatabaseHandler.CheckRolePrecondition(context.Guild.Id.ToString());

            if (!(context.User is SocketGuildUser user)) { return Task.FromResult(PreconditionResult.FromError("The command was not used in a guild.")); }

            var matchingRoles = context.Guild.Roles.Where(role => roleNames.Contains(role.Name.ToLower()));
            if (matchingRoles == null) { return Task.FromResult(PreconditionResult.FromError("There are no matching roles on the server.")); }

            if (user.Roles.Any(role => matchingRoles.Contains(role)))
            {
                if(context.Channel.Id == 412015604698972160)
                {
                    return Task.FromResult(PreconditionResult.FromSuccess());
                }
            }

            return Task.FromResult(PreconditionResult.FromError("The user did not have any matching roles for Role Play Commands."));
        }
    }
}
