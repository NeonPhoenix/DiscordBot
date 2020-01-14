using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Builder;
using DiscordBot.Events;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [ComVisible(false)]
    public class ReactionModule : ModuleBase<SocketCommandContext>
    {
        #region ReactionEmbed
        [Command("kiss")]
        public async Task KissAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.KissReaction(), "kisses").Build(), null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.TickleReaction(), "tickles").Build(), null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.PinchReaction(), "pinches").Build(), null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.WaveReaction(), "waves at").Build(), null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.FlipReaction(), "flips off").Build(), null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.CakeReaction(), "gives cake to").Build(), null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.CuddleReaction(), "cuddles").Build(), null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlareAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.GlareReaction(), "glares at").Build(), null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.HighfiveReaction(), "highfives").Build(), null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.HugReaction(), "hugs").Build(), null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.PokeReaction(), "pokes").Build(), null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.PunchReaction(), "punches").Build(), null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.PatReaction(), "pats").Build(), null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.PetReaction(), "pets").Build(), null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.SlapReaction(), "slaps").Build(), null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.BiteReaction(), "bites").Build(), null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.GrooveReaction(), "grooves with").Build(), null).ConfigureAwait(false);
        }

        [Command("confused")]
        public async Task ConfusedAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.ConfusedReaction(), "is confused by").Build(), null).ConfigureAwait(false);
        }

        [Command("pout")]
        public async Task PoutAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.PoutReaction(), "pouts at").Build(), null).ConfigureAwait(false);
        }

        [Command("stare")]
        public async Task StareAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.StareReaction(), "stares at").Build(), null).ConfigureAwait(false);
        }

        [Command("cry")]
        public async Task CryAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.CriesReaction(), "cries at").Build(), null).ConfigureAwait(false);
        }

        [Command("tackle")]
        public async Task TackleAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.TackleReaction(), "tackles").Build(), null).ConfigureAwait(false);
        }

        [Command("suplex")]
        public async Task SuplexAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.SuplexeReaction(), "suplexes").Build(), null).ConfigureAwait(false);
        }

        [Command("love")]
        public async Task LoveAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.LoveReaction(), "sends love to").Build(), null).ConfigureAwait(false);
        }

        [Command("heart")]
        public async Task HeartAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.HeartReaction(), "hearts").Build(), null).ConfigureAwait(false);
        }

        [Command("drool")]
        public async Task DroolAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.DroolReaction(), "drools at").Build(), null).ConfigureAwait(false);
        }

        [Command("cookie")]
        public async Task CookieAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.CookieReaction(), "gives cookie to").Build(), null).ConfigureAwait(false);
        }

        [Command("meow")]
        public async Task MeowAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, usr, ImageEvents.MeowReaction(), "meows at").Build(), null).ConfigureAwait(false);
        }
        #endregion

        #region ReactionEmbed2 Commands
        [Command("smug")]
        public async Task SmugAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2(Context, ImageEvents.SmugReaction(), "is acting smug").Build(), null).ConfigureAwait(false);
        }

        [Command("lewd")]
        public async Task LewdAsync(SocketGuildUser usr = null)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2(Context, ImageEvents.LewdReaction(), "thinks that's lewd").Build(), null).ConfigureAwait(false);
        }
        #endregion
    }
}
