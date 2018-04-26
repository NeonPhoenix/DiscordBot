using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Init;

namespace DiscordBot.Modules
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        privare readonly CommandService _service;
        private readonly IConfigurationRoot _config;
        
        public AdminCommands(CommandService service, IConfigurationRoot config)
        {
            _service = service;
            _config - config;
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
        public async Task PrefixAsysnc()
        {
            string prefix = _config["Prefix"];
            var builder = new EmbedBuilder() { Color = new Color(114, 137, 218) };
            builder.AddField($"Current set prefix is {prefix}!");
            
            await ReplyAsync("", false, builder.Build();
        }
        
        [Command("prefix"), Priority(0)]
        public async Task PrefixAsync(string prefix)
        {
            var builder = new EmbedBuilder() { Color = new Color(114, 137, 218) };
            _config.GetSection("Prefix").Bind(prefix);
            builder.AddField($"Prefix has been changed to {prefix}!");
            
            await ReplyAsync("", false, builder.Build();
        }
    }
}
