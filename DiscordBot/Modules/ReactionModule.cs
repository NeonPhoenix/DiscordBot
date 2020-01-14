using Discord.Commands;
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
        public async Task KissAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.KissReaction(), "kisses", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.TickleReaction(), "tickles", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.PinchReaction(), "pinches", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.WaveReaction(), "waves at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.FlipReaction(), "flips off", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.CakeReaction(), "gives cake to", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.CuddleReaction(), "cuddles", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlareAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.GlareReaction(), "glares at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.HighfiveReaction(), "highfives", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.HugReaction(), "hugs", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.PokeReaction(), "pokes", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.PunchReaction(), "punches", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.PatReaction(), "pats", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.PetReaction(), "pets", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.SlapReaction(), "slaps", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.BiteReaction(), "bites", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.GrooveReaction(), "grooves with", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("confused")]
        public async Task ConfusedAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.ConfusedReaction(), "is confused by", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("pout")]
        public async Task PoutAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.PoutReaction(), "pouts at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("stare")]
        public async Task StareAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.StareReaction(), "stares at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("cry")]
        public async Task CryAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.CriesReaction(), "cries at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("tackle")]
        public async Task TackleAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.TackleReaction(), "tackles", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("suplex")]
        public async Task SuplexAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.SuplexeReaction(), "suplexes", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("love")]
        public async Task LoveAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.LoveReaction(), "sends love to", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("heart")]
        public async Task HeartAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.HeartReaction(), "hearts", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("drool")]
        public async Task DroolAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.DroolReaction(), "drools at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("cookie")]
        public async Task CookieAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.CookieReaction(), "gives cookie to", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("meow")]
        public async Task MeowAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed(Context, ImageEvents.MeowReaction(), "meows at", msg).Build(), null).ConfigureAwait(false);
        }
        #endregion

        #region ReactionEmbed2 Commands
        [Command("smug")]
        public async Task SmugAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2(Context, ImageEvents.SmugReaction(), "is acting smug", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("lewd")]
        public async Task LewdAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2(Context, ImageEvents.LewdReaction(), "thinks that's lewd", msg).Build(), null).ConfigureAwait(false);
        }
        #endregion
    }
}
