using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Init;

namespace DiscordBot.Modules
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        private readonly CommandService _service;
        private readonly IConfigurationRoot _config;
        
        public AdminCommands(CommandService service, IConfigurationRoot config)
        {
            _service = service;
            _config = config;
        }
    
        [Command("kick")]
        [RequireUserPermission(GuildPermission.KickMembers)]
        public async Task Kick(SocketGuildUser usr, [Remainder]string name)
        {
            await ReplyAsync($"Goodbye {usr.Mention} :wave:");
            await usr.KickAsync();
        }

        [Command("reloadimages")]
        [Summary("Reload Image list for SFW and NSFW Commands.")]
        [RequireUserPermission(GuildPermission.ManageChannels)]
        public async Task ReloadImage()
        {
            ImageInitialization.Clear();
            ImageInitialization.Init();
            await Context.Channel.SendMessageAsync("Reload Complete!");
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
