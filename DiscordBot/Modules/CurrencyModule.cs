using Discord.Commands;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class CurrencyModule
    {
        [Command("money"), Alias("bal")]
        public async Task ShowCurrentBalance()
        {

        }

        [Command("daily")]
        public async Task GetDailyMoney()
        {

        }

        [Command("give")]
        public async Task GiveCurrency()
        {

        }
    }
}
