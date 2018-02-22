using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class CoreCommands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong!");
        }

        [Command("help")]
        public async Task Help()
        {

        }

        [Command("stats")]
        public async Task Stats()
        {

        }

        [Command("shard")]
        public async Task Shard()
        {

        }

        [Command("info")]
        public async Task Info()
        {

        }

        [Command("patreon")]
        public async Task Patreon()
        {

        }

        [Command("server")]
        public async Task Server()
        {

        }

        [Command("userinfo")]
        public async Task UserInfo()
        {

        }

        [Command("edit")]
        public async Task Edit()
        {

        }
    }

    [Group("prefix")]
    public class PrefixModule : ModuleBase
    {
        [Command]
        public async Task Prefix()
        {

        }

        [Command("default")]
        public async Task DefaultPrefix()
        {

        }

        [Command("change")]
        public async Task ChangePrefix()
        {

        }
    }

    [Group("clean")]
    public class CleanModule : ModuleBase
    {
        [Command]
        public async Task Clean()
        {

        }

        [Command("delmsgoncmd")]
        public async Task DeleteMessageOnCmd()
        {

        }
    }

    [Group("invite")]
    public class InviteModule : ModuleBase
    {
        [Command]
        public async Task Invite()
        {
            
        }
    }

    [Group("group")]
    public class GroupModule : ModuleBase
    {
        [Command]
        public async Task Group()
        {

        }

        [Command("enable")]
        public async Task EnableGroup()
        {

        }

        [Command("disable")]
        public async Task DisableGroup()
        {

        }
    }

    [Group("donators")]
    public class DonatorsModule : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task Donators()
        {

        }

        [Command("add")]
        public async Task AddDonator()
        {

        }

        [Command("remove")]
        public async Task RemoveDonator()
        {

        }
    }

    [Group("voicechannel")]
    public class VoiceChannel : ModuleBase
    {
        [Command]
        public async Task Voice()
        {

        }

        [Command("create")]
        public async Task CreateVoice()
        {

        }

        [Command("delete")]
        public async Task DeleteVoice()
        {

        }
    }

    [Group("textchannel")]
    public class TextChannel : ModuleBase
    {
        [Command]
        public async Task Text()
        {

        }

        [Command("create")]
        public async Task CreateText()
        {

        }

        [Command("delete")]
        public async Task DeleteText()
        {

        }

        [Command("settopic")]
        public async Task SetTopicText()
        {

        }
    }
}
