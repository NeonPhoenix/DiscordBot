using Discord;
using Discord.Commands;
using DiscordBot.Handlers;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DiscordBot.Modules
{
    [ComVisible(false)]
    public class BotCommands : ModuleBase<SocketCommandContext>
    {
        private readonly CommandService _service;
        private readonly IConfigurationRoot _config;

        public BotCommands(CommandService service, IConfigurationRoot config)
        {
            _service = service;
            _config = config;
        }

        [Command("prefix")]
        public async Task PrefixAsync()
        {
            string prefix = DatabaseHandler.CheckGuildPrefix(Context.Guild.Id.ToString());
            await ReplyAsync($"Current set prefix is {prefix}");
        }

        [Command("prefix")]
        [RequireUserPermission(GuildPermission.ManageGuild)]
        public async Task PrefixAsync(string newPrefix)
        {
            DatabaseHandler.ChangeGuildPrefix(Context.Guild.Id.ToString(), Context.Guild.Name.ToString(), newPrefix);
            await ReplyAsync($"Prefix has been changed to {newPrefix}");
        }
    }
}
