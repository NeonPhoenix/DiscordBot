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
        #region ReactionEmbed No User
        [Command("kiss")]
        public async Task KissAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("kiss"), "kisses").Build(), null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("tickle"), "tickles").Build(), null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("pinch"), "pinches").Build(), null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("wave"), "waves at").Build(), null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("middle finger"), "flips off").Build(), null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("cake"), "gives cake to").Build(), null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("cuddle"), "cuddles").Build(), null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlareAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("glare"), "glares at").Build(), null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("highfive"), "highfives").Build(), null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("hug"), "hugs").Build(), null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("poke"), "pokes").Build(), null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("punch"), "punches").Build(), null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("pat"), "pats").Build(), null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("pets"), "pets").Build(), null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("slap"), "slaps").Build(), null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("bite"), "bites").Build(), null).ConfigureAwait(false);
        }

        [Command("parrot"), Alias("groove")]
        public async Task ParrotAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("grooving"), "grooves with").Build(), null).ConfigureAwait(false);
        }

        [Command("confused")]
        public async Task ConfusedAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("confused"), "is confused by").Build(), null).ConfigureAwait(false);
        }

        [Command("pout")]
        public async Task PoutAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("pouts"), "pouts at").Build(), null).ConfigureAwait(false);
        }

        [Command("stare")]
        public async Task StareAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("stares"), "stares at").Build(), null).ConfigureAwait(false);
        }

        [Command("cry")]
        public async Task CryAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("crying"), "cries at").Build(), null).ConfigureAwait(false);
        }

        [Command("tackle")]
        public async Task TackleAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("tackle"), "tackles").Build(), null).ConfigureAwait(false);
        }

        [Command("suplex")]
        public async Task SuplexAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("suplex"), "suplexes").Build(), null).ConfigureAwait(false);
        }

        [Command("love")]
        public async Task LoveAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("love"), "sends love to").Build(), null).ConfigureAwait(false);
        }

        [Command("heart")]
        public async Task HeartAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("heart"), "hearts").Build(), null).ConfigureAwait(false);
        }

        [Command("drool")]
        public async Task DroolAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("drool"), "drools at").Build(), null).ConfigureAwait(false);
        }

        [Command("cookie")]
        public async Task CookieAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("cookie"), "gives cookie to").Build(), null).ConfigureAwait(false);
        }

        [Command("meow")]
        public async Task MeowAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed((IGuildUser)Context.User, ImageEvents.ReactionImage("meows"), "meows at").Build(), null).ConfigureAwait(false);
        }
        #endregion

        #region ReactionEmbed Mentioned User
        [Command("kiss")]
        public async Task KissAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("kiss"), "kisses").Build(), null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("tickle"), "tickles").Build(), null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("pinch"), "pinches").Build(), null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("wave"), "waves at").Build(), null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("middle finger"), "flips off").Build(), null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("cake"), "gives cake to").Build(), null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("cuddle"), "cuddles").Build(), null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlareAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("glare"), "glares at").Build(), null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("highfive"), "highfives").Build(), null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("hug"), "hugs").Build(), null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("poke"), "pokes").Build(), null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("punch"), "punches").Build(), null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("pat"), "pats").Build(), null).ConfigureAwait(false);
        }

        [Command("pet")]
        public async Task PetAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("pet"), "pets").Build(), null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("slap"), "slaps").Build(), null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("bite"), "bites").Build(), null).ConfigureAwait(false);
        }

        [Command("groove")]
        public async Task ParrotAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("groove"), "grooves with").Build(), null).ConfigureAwait(false);
        }

        [Command("confused")]
        public async Task ConfusedAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("confused"), "is confused by").Build(), null).ConfigureAwait(false);
        }

        [Command("pout")]
        public async Task PoutAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("pout"), "pouts at").Build(), null).ConfigureAwait(false);
        }

        [Command("stare")]
        public async Task StareAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("stare"), "stares at").Build(), null).ConfigureAwait(false);
        }

        [Command("cry")]
        public async Task CryAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("cry"), "cries at").Build(), null).ConfigureAwait(false);
        }

        [Command("tackle")]
        public async Task TackleAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("tackle"), "tackles").Build(), null).ConfigureAwait(false);
        }

        [Command("suplex")]
        public async Task SuplexAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("suplex"), "suplexes").Build(), null).ConfigureAwait(false);
        }

        [Command("love")]
        public async Task LoveAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("love"), "sends love to").Build(), null).ConfigureAwait(false);
        }

        [Command("heart")]
        public async Task HeartAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("heart"), "hearts").Build(), null).ConfigureAwait(false);
        }

        [Command("drool")]
        public async Task DroolAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("drool"), "drools at").Build(), null).ConfigureAwait(false);
        }

        [Command("cookie")]
        public async Task CookieAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("cookie"), "gives cookie to").Build(), null).ConfigureAwait(false);
        }

        [Command("meow")]
        public async Task MeowAsync(SocketGuildUser usr)
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbedMention((IGuildUser)Context.User, usr, ImageEvents.ReactionImage("meow"), "meows at").Build(), null).ConfigureAwait(false);
        }
        #endregion

        #region ReactionEmbed2 Commands
        [Command("smug")]
        public async Task SmugAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2((IGuildUser)Context.User, ImageEvents.ReactionImage("smug"), "is acting smug").Build(), null).ConfigureAwait(false);
        }

        [Command("lewd")]
        public async Task LewdAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2((IGuildUser)Context.User, ImageEvents.ReactionImage("lewd"), "thinks that's lewd").Build(), null).ConfigureAwait(false);
        }        
        
        [Command("cheer")]
        public async Task CheerAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2((IGuildUser)Context.User, ImageEvents.ReactionImage("cheer"), "cheers").Build(), null).ConfigureAwait(false);
        }

        [Command("bored")]
        public async Task BoredAsync()
        {
            await Context.Channel.SendMessageAsync("", false, CommandEmbedBuilder.ReactionEmbed2((IGuildUser)Context.User, ImageEvents.ReactionImage("bored"), "is super bored").Build(), null).ConfigureAwait(false);
        }
        #endregion
    }
}
