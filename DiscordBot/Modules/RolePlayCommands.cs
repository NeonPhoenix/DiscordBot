using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Builder;
using DiscordBot.CustomPreconditions;
using DiscordBot.Events;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [RolePlayRoles]
    public class RolePlayCommands : ModuleBase<SocketCommandContext>
    {
        private CommandEmbedBuilder _emb = new CommandEmbedBuilder();
        Random ran = new Random();

        [Command("rub")]
        public async Task RubAsync(SocketUser usr, string bodyPart)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "rub", bodyPart);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("french")]
        public async Task FrenchAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "french kisses");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("makeout")]
        public async Task MakeOutAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "makes out with");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        //[Command("bind")]
        //public async Task BindAsync(SocketUser usr = null, string bodyPart)
        //{

        //}

        //[Command("suspend")]

        //[Command("nibble")]

        //[Command("bite")]

        //[Command("lick")]

        //[Command("blind")]

        //[Command("gag")]

        //[Command("choke")]

        //[Command("slap")]

        //[Command("spank")]

        //[Command("flog")]

        //[Command("whip")]

        //[Command("cane")]

        //[Command("clamp")]

        //[Command("pull")]

        //[Command("eat")]

        //[Command("finger")]

        //[Command("fist")]

        //[Command("fuck")]

        //[Command("ride")]

        //[Command("sit")]

        //[Command("pound")]

        //[Command("toy")]

        //[Command("stuff")]

        //[Command("cum")]

        //[Command("69")]
    }
}
