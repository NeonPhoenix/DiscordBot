using Discord;
using Discord.Commands;
using DiscordBot.Events;
using DiscordBot.Init;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class ReactionCommands : ModuleBase<SocketCommandContext>
    {  
        Random ran = new Random();

        [Command("kiss")]
        public async Task KissAsync(params string[] msg)
        {
            string img = ImageInitialization.Kiss[ran.Next(0, ImageInitialization.Kiss.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "kisses", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("kiss")]
        public async Task KissAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Kiss[ran.Next(0, ImageInitialization.Kiss.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "kisses", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(params string[] msg)
        {
            string img = ImageInitialization.Tickle[ran.Next(0, ImageInitialization.Tickle.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "tickles", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Tickle[ran.Next(0, ImageInitialization.Tickle.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "tickles", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(params string[] msg)
        {
            string img = ImageInitialization.Pinch[ran.Next(0, ImageInitialization.Pinch.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "pinches", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Pinch[ran.Next(0, ImageInitialization.Pinch.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "pinches", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(params string[] msg)
        {
            string img = ImageInitialization.Wave[ran.Next(0, ImageInitialization.Wave.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "waves at", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Wave[ran.Next(0, ImageInitialization.Wave.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "waves at", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(params string[] msg)
        {
            string img = ImageInitialization.Rude[ran.Next(0, ImageInitialization.Rude.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "flips off", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Rude[ran.Next(0, ImageInitialization.Rude.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "flips off", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(params string[] msg)
        {
            string img = ImageInitialization.Cake[ran.Next(0, ImageInitialization.Cake.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "gives cake to", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Cake[ran.Next(0, ImageInitialization.Cake.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "gives cake to", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(params string[] msg)
        {
            string img = ImageInitialization.Cuddle[ran.Next(0, ImageInitialization.Cuddle.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "cuddles", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Cuddle[ran.Next(0, ImageInitialization.Cuddle.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "cuddles", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlaresAsync(params string[] msg)
        {
            string img = ImageInitialization.Glare[ran.Next(0, ImageInitialization.Glare.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "glares at", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlaresAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Glare[ran.Next(0, ImageInitialization.Glare.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "glares at", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(params string[] msg)
        {
            string img = ImageInitialization.Highfive[ran.Next(0, ImageInitialization.Highfive.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "highfives", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Highfive[ran.Next(0, ImageInitialization.Highfive.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "highfives", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(params string[] msg)
        {
            string img = ImageInitialization.Hug[ran.Next(0, ImageInitialization.Hug.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "hugs", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Hug[ran.Next(0, ImageInitialization.Hug.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "hugs", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(params string[] msg)
        {
            string img = ImageInitialization.Poke[ran.Next(0, ImageInitialization.Poke.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "pokes", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Poke[ran.Next(0, ImageInitialization.Poke.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "pokes", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(params string[] msg)
        {
            string img = ImageInitialization.Punch[ran.Next(0, ImageInitialization.Punch.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "punches", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Punch[ran.Next(0, ImageInitialization.Punch.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "punches", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(params string[] msg)
        {
            string img = ImageInitialization.Pat[ran.Next(0, ImageInitialization.Pat.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "pats", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Pat[ran.Next(0, ImageInitialization.Pat.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "pats", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync(params string[] msg)
        {
            string img = ImageInitialization.Pat[ran.Next(0, ImageInitialization.Pat.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "pets", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Pat[ran.Next(0, ImageInitialization.Pat.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "pets", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(params string[] msg)
        {
            string img = ImageInitialization.Slap[ran.Next(0, ImageInitialization.Slap.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "slaps", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Slap[ran.Next(0, ImageInitialization.Slap.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "slaps", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(params string[] msg)
        {
            string img = ImageInitialization.Bite[ran.Next(0, ImageInitialization.Bite.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "bites", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Bite[ran.Next(0, ImageInitialization.Bite.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "bites", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("lick")]
        public async Task LickAsync(params string[] msg)
        {
            string img = ImageInitialization.Lick[ran.Next(0, ImageInitialization.Lick.Count)];
            var em = CommandEvent.ReactionEmbed(Context, null, "licks", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("lick")]
        public async Task LickAsync(IUser usr = null, params string[] msg)
        {
            string img = ImageInitialization.Lick[ran.Next(0, ImageInitialization.Lick.Count)];
            var em = CommandEvent.ReactionEmbed(Context, usr, "licks", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync(params string[] msg)
        {
            string img = "https://i.imgur.com/pTUXcmI.gif";
            var em = CommandEvent.ReactionEmbed(Context, null, "grooves with", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync(IUser usr = null, params string[] msg)
        {
            string img = "https://i.imgur.com/pTUXcmI.gif";
            var em = CommandEvent.ReactionEmbed(Context, usr, "grooves with", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }
    }
}
