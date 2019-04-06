using Discord.Commands;
using DiscordBot.Preconditions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [ModuleStatus]
    [ComVisible(false)]
    public class CurrencyModule : ModuleBase<SocketCommandContext>
    {
        [Command("money"), Alias("bal")]
        public async Task ShowCurrentBalance()
        {
            await Context.Channel.SendMessageAsync("This command has yet to be configured.").ConfigureAwait(false);
        }

        [Command("daily")]
        public async Task GetDailyMoney()
        {
            await Context.Channel.SendMessageAsync("This command has yet to be configured.").ConfigureAwait(false);
        }

        [Command("give")]
        public async Task GiveCurrency()
        {
            await Context.Channel.SendMessageAsync("This command has yet to be configured.").ConfigureAwait(false);
        }
    }
}
