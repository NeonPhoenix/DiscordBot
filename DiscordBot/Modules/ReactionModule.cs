using Discord.Commands;
using DiscordBot.Builder;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [ComVisible(false)]
    public class ReactionModule : ModuleBase<SocketCommandContext>
    {
        private CommandEmbedBuilder _emb = new CommandEmbedBuilder();

        #region ReactionEmbed
        [Command("kiss")]
        public async Task KissAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed2(Context, "kisses", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "tickles", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "pinches", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "waves at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "flips off", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "gives cake to", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "cuddles", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlareAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "glares at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "highfives", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "hugs", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "pokes", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "punches", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "pats", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "pets", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "slaps", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "bites", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "grooves with", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("confused")]
        public async Task ConfusedAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "is confused by", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("pout")]
        public async Task PoutAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "pouts at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("stare")]
        public async Task StareAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "stares at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("cry")]
        public async Task CryAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "cries at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("tackle")]
        public async Task TackleAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "tackles", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("suplex")]
        public async Task SuplexAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "suplexes", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("love")]
        public async Task LoveAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "sends love to", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("heart")]
        public async Task HeartAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "hearts", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("drool")]
        public async Task DroolAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "drools at", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("cookie")]
        public async Task CookieAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "gives cookie to", msg).Build(), null).ConfigureAwait(false);
        }

        public async Task MeowAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed(Context, "meows at", msg).Build(), null).ConfigureAwait(false);
        }
        #endregion

        #region ReactionEmbed2 Commands
        [Command("smug")]
        public async Task SmugAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed2(Context, "is acting smug", msg).Build(), null).ConfigureAwait(false);
        }

        [Command("lewd")]
        public async Task LewdAsync(params string[] msg)
        {
            await Context.Channel.SendMessageAsync("", false, _emb.ReactionEmbed2(Context, "thinks that's lewd", msg).Build(), null).ConfigureAwait(false);
        }
        #endregion
    }
}
