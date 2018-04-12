using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace DiscordBot.Modules
{
    [Group("admin")]
    public class AdminCommands
    {
        [Group("clean")]
        public class CleanModule : ModuleBase<SocketCommandContext>
        {
            [Command]
            public async Task Default(int count = 10) => Messages(count);

            [Command("messages")]
            public async Task Messages(int count = 10) { }
        }

        [Command("ban")]
        public async Task Ban(IGuildUser user)
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
}
