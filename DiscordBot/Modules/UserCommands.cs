using Discord;
using Discord.Commands;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class UserCommands : ModuleBase<SocketCommandContext>
    {
        [Command("setav")]
        public async Task SetAvatarAsync(ISelfUser usr, [Remainder] string img = null)
        {
            if (string.IsNullOrWhiteSpace(img)) return;

            using (var http = new HttpClient())
            {
                using (var sr = await http.GetStreamAsync(img))
                {
                    var imgStream = new MemoryStream();
                    await sr.CopyToAsync(imgStream);
                    imgStream.Position = 0;

                    await usr.ModifyAsync(x => x.Avatar = new Image(imgStream)).ConfigureAwait(false);
                }
            }
        }
    }
}
