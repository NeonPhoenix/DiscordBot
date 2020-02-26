using Discord;
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
        //TODO Add more images to groove command
        //TODO Change command to "groove"

        #region ReactionEmbed No User
        [Command("kiss")]
        public async Task KissAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.KissReaction(), "kisses").Build(), null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.TickleReaction(), "tickles").Build(), null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.PinchReaction(), "pinches").Build(), null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.WaveReaction(), "waves at").Build(), null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.FlipReaction(), "flips off").Build(), null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.CakeReaction(), "gives cake to").Build(), null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.CuddleReaction(), "cuddles").Build(), null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlareAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.GlareReaction(), "glares at").Build(), null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.HighfiveReaction(), "highfives").Build(), null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.HugReaction(), "hugs").Build(), null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.PokeReaction(), "pokes").Build(), null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.PunchReaction(), "punches").Build(), null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.PatReaction(), "pats").Build(), null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.PetReaction(), "pets").Build(), null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.SlapReaction(), "slaps").Build(), null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.BiteReaction(), "bites").Build(), null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.GrooveReaction(), "grooves with").Build(), null).ConfigureAwait(false);
        }

        [Command("confused")]
        public async Task ConfusedAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ConfusedReaction(), "is confused by").Build(), null).ConfigureAwait(false);
        }

        [Command("pout")]
        public async Task PoutAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.PoutReaction(), "pouts at").Build(), null).ConfigureAwait(false);
        }

        [Command("stare")]
        public async Task StareAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.StareReaction(), "stares at").Build(), null).ConfigureAwait(false);
        }

        [Command("cry")]
        public async Task CryAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.CriesReaction(), "cries at").Build(), null).ConfigureAwait(false);
        }

        [Command("tackle")]
        public async Task TackleAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.TackleReaction(), "tackles").Build(), null).ConfigureAwait(false);
        }

        [Command("suplex")]
        public async Task SuplexAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.SuplexeReaction(), "suplexes").Build(), null).ConfigureAwait(false);
        }

        [Command("love")]
        public async Task LoveAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.LoveReaction(), "sends love to").Build(), null).ConfigureAwait(false);
        }

        [Command("heart")]
        public async Task HeartAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.HeartReaction(), "hearts").Build(), null).ConfigureAwait(false);
        }

        [Command("drool")]
        public async Task DroolAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.DroolReaction(), "drools at").Build(), null).ConfigureAwait(false);
        }

        [Command("cookie")]
        public async Task CookieAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.CookieReaction(), "gives cookie to").Build(), null).ConfigureAwait(false);
        }

        [Command("meow")]
        public async Task MeowAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.MeowReaction(), "meows at").Build(), null).ConfigureAwait(false);
        }
        #endregion

        #region ReactionEmbed Mentioned User
        [Command("kiss")]
        public async Task KissAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.KissReaction(), "kisses").Build(), null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.TickleReaction(), "tickles").Build(), null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.PinchReaction(), "pinches").Build(), null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.WaveReaction(), "waves at").Build(), null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.FlipReaction(), "flips off").Build(), null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.CakeReaction(), "gives cake to").Build(), null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.CuddleReaction(), "cuddles").Build(), null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlareAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.GlareReaction(), "glares at").Build(), null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.HighfiveReaction(), "highfives").Build(), null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.HugReaction(), "hugs").Build(), null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.PokeReaction(), "pokes").Build(), null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.PunchReaction(), "punches").Build(), null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.PatReaction(), "pats").Build(), null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.PetReaction(), "pets").Build(), null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.SlapReaction(), "slaps").Build(), null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.BiteReaction(), "bites").Build(), null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.GrooveReaction(), "grooves with").Build(), null).ConfigureAwait(false);
        }

        [Command("confused")]
        public async Task ConfusedAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ConfusedReaction(), "is confused by").Build(), null).ConfigureAwait(false);
        }

        [Command("pout")]
        public async Task PoutAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.PoutReaction(), "pouts at").Build(), null).ConfigureAwait(false);
        }

        [Command("stare")]
        public async Task StareAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.StareReaction(), "stares at").Build(), null).ConfigureAwait(false);
        }

        [Command("cry")]
        public async Task CryAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.CriesReaction(), "cries at").Build(), null).ConfigureAwait(false);
        }

        [Command("tackle")]
        public async Task TackleAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.TackleReaction(), "tackles").Build(), null).ConfigureAwait(false);
        }

        [Command("suplex")]
        public async Task SuplexAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.SuplexeReaction(), "suplexes").Build(), null).ConfigureAwait(false);
        }

        [Command("love")]
        public async Task LoveAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.LoveReaction(), "sends love to").Build(), null).ConfigureAwait(false);
        }

        [Command("heart")]
        public async Task HeartAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.HeartReaction(), "hearts").Build(), null).ConfigureAwait(false);
        }

        [Command("drool")]
        public async Task DroolAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.DroolReaction(), "drools at").Build(), null).ConfigureAwait(false);
        }

        [Command("cookie")]
        public async Task CookieAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.CookieReaction(), "gives cookie to").Build(), null).ConfigureAwait(false);
        }

        [Command("meow")]
        public async Task MeowAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.MeowReaction(), "meows at").Build(), null).ConfigureAwait(false);
        }
        #endregion

        #region ReactionEmbed2 Commands
        //TODO Make bored command
        [Command("smug")]
        public async Task SmugAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2((IGuildUser)Context.User, ImageEvents.SmugReaction(), "is acting smug").Build(), null).ConfigureAwait(false);
        }

        [Command("lewd")]
        public async Task LewdAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2((IGuildUser)Context.User, ImageEvents.LewdReaction(), "thinks that's lewd").Build(), null).ConfigureAwait(false);
        }        
        
        [Command("cheer")]
        public async Task CheerAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2((IGuildUser)Context.User, ImageEvents.CheerReaction(), "cheers").Build(), null).ConfigureAwait(false);
        }
        #endregion
    }
}
