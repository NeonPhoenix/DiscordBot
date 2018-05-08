using Discord.Commands;
using DiscordBot.Builder;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class ReactionCommands : ModuleBase<SocketCommandContext>
    {
        private CommandEmbedBuilder _emb = new CommandEmbedBuilder();
        Random ran = new Random();

        [Command("kiss")]
        public async Task KissAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "kisses", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "tickles", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "pinches", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "waves at", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "flips off", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "gives cake to", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "cuddles", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlareAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "glares at", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "highfives", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "hugs", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "pokes", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "punches", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "pats", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "pets", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "slaps", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "bites", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("lick")]
        public async Task LickAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "licks", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync(params string[] msg)
        {
            var em = _emb.ReactionEmbed(Context, "grooves with", msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }
    }
}
