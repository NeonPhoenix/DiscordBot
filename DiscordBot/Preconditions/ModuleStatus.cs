using Discord.Commands;
using DiscordBot.Managers;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Preconditions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ModuleStatus : PreconditionAttribute
    {
        private Task<PreconditionResult> result;

        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider services)
        {
            if (DatabaseManager.CheckModuleStatus(command.Module.Name, context.Guild.Id.ToString()).Equals("true"))
            {
                result = Task.FromResult(PreconditionResult.FromSuccess());
            }
            else if(DatabaseManager.CheckModuleStatus(command.Module.Name, context.Guild.Id.ToString()).Equals("false"))
            {
                result = Task.FromResult(PreconditionResult.FromError($"Sorry! This command is apart of {command.Module.Name} which is currently disabled!"));
            }

            return result;
        }
    }
}
