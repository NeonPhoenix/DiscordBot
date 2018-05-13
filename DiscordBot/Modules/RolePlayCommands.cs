using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Builder;
using DiscordBot.CustomPreconditions;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [RolePlayRoles]
    public class RolePlayCommands : ModuleBase<SocketCommandContext>
    {
        private CommandEmbedBuilder _emb = new CommandEmbedBuilder();
        readonly Random ran = new Random();

        [Command("rub")]
        public async Task RubAsync(SocketUser usr, string bodyPart)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "rub", bodyPart);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }


        #region User only commands
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

        [Command("eat")]
        public async Task EatOutAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "eats out");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("blind")]
        public async Task BlindfoldAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "blindfolds");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("choke")]
        public async Task ChokeAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "chokes");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("69")]
        public async Task SixtyNineAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "69's with");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("finger")]
        public async Task FingersAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "fingers");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("fist")]
        public async Task FistAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "fists");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("ride")]
        public async Task RideAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "rides");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pound")]
        public async Task PoundAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "pounds");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("toy")]
        public async Task ToyAsync(SocketUser usr = null)
        {
            var em = _emb.RolePlayEmbed(Context, usr, "toys with");
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }
        #endregion
    }
}
