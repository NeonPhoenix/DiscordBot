using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBot.CustomPreconditions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RolePlayRoles : PreconditionAttribute
    {
        public override Task<PreconditionResult> CheckPermissions(ICommandContext context, CommandInfo command, IServiceProvider service)
        {
            string[] roleNames = { "vip", "fox courtiers", "fox prince", "fox princess", "fox king", "fox queen" };

            if (!(context.User is SocketGuildUser user)) { return Task.FromResult(PreconditionResult.FromError("The command was not used in a guild.")); }

            var matchingRoles = context.Guild.Roles.Where(role => roleNames.Any(name => name == role.Name.ToLower()));
            if (matchingRoles == null) { return Task.FromResult(PreconditionResult.FromError("There are no matching roles on the server.")); }

            if (user.Roles.Any(role => matchingRoles.Contains(role))) { return Task.FromResult(PreconditionResult.FromSuccess()); }

            return Task.FromResult(PreconditionResult.FromError("The user did not have any matching roles for Role Play Commands."));
        }
    }
}
