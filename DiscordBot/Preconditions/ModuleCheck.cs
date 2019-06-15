using Discord;
using Discord.Commands;
using DiscordBot.Managers;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Preconditions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class ModuleCheck : PreconditionAttribute
    {
        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider service)
        {
            if (!(context.User is IGuildUser user)) { return Task.FromResult(PreconditionResult.FromError("The command was not used in a guild!")); }

            if (DatabaseManager.CheckModuleStatus(command.Module.Name, context.Guild.Id.ToString()).Equals("false"))
            {
                return Task.FromResult(PreconditionResult.FromError($"Sorry! This command is apart of {command.Module.Name} which is currently disabled!"));
            }

            return Task.FromResult(PreconditionResult.FromSuccess());
        }
    }
}
