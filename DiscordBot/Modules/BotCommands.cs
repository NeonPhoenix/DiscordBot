using Discord;
using Discord.Commands;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class BotCommands : ModuleBase<SocketCommandContext>
    {
        private readonly CommandService _service;
        private readonly IConfigurationRoot _config;

        public BotCommands(CommandService service, IConfigurationRoot config)
        {
            _service = service;
            _config = config;
        }

        [Command("prefix"), Priority(1)]
        [RequireUserPermission(GuildPermission.ManageGuild)]
        public async Task PrefixAsysnc()
        {
            string prefix = _config["Prefix"];
            await ReplyAsync($"Current set prefix is {prefix}!");
        }

        [Command("prefix"), Priority(0)]
        [RequireUserPermission(GuildPermission.ManageGuild)]
        public async Task PrefixAsync(string prefix)
        {
            _config.GetSection("Prefix").Value = prefix;
            await ReplyAsync($"Prefix has been changed to {prefix}!");
        }
    }
}
