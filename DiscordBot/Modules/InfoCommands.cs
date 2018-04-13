using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class InfoCommands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            var sw = Stopwatch.StartNew();
            var msg = await Context.Channel.SendMessageAsync("PONG!").ConfigureAwait(false);
            sw.Stop();
            await msg.DeleteAsync(null);

            await Context.Channel.SendMessageAsync($"{Format.Bold(Context.User.ToString())} 🏓 {(int)sw.Elapsed.TotalMilliseconds}ms").ConfigureAwait(false);
        }

        [Command("help")]
        public async Task Help()
        {

        }

        [Command("stats")]
        public async Task Stats()
        {
            TimeSpan timeSinceStart = DateTime.Now.Subtract(Program.timeSinceStartup);
        }

        [Command("shard")]
        public async Task Shard()
        {

        }

        [Command("guildinfo")]
        [RequireContext(ContextType.Guild)]
        public async Task ServerInfo()
        {
            var createdAt = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Context.Guild.Id >> 22);
            var features = string.Join("\n", Context.Guild.Features);
            if (string.IsNullOrWhiteSpace(features)) { features = "-"; }

            var embed = new EmbedBuilder()
                .WithTitle(Context.Guild.Name)
                .AddField(fb => fb.WithName("Server ID").WithValue(Context.Guild.Id.ToString()).WithIsInline(true))
                .AddField(fb => fb.WithName("Owner").WithValue(Context.Guild.Owner.ToString()).WithIsInline(true))
                .AddField(fb => fb.WithName("Members").WithValue(Context.Guild.MemberCount.ToString()).WithIsInline(true))
                .AddField(fb => fb.WithName("Text Channels").WithValue(Context.Guild.TextChannels.Count().ToString()).WithIsInline(true))
                .AddField(fb => fb.WithName("Voice Channels").WithValue(Context.Guild.VoiceChannels.Count().ToString()).WithIsInline(true))
                .AddField(fb => fb.WithName("Created On:").WithValue($"{createdAt:dd.MM.yyyy HH:mm}").WithIsInline(true))
                .AddField(fb => fb.WithName("Region").WithValue(Context.Guild.VoiceRegionId.ToString()).WithIsInline(true))
                .AddField(fb => fb.WithName("Roles").WithValue((Context.Guild.Roles.Count - 1).ToString()).WithIsInline(true))
                .AddField(fb => fb.WithName("Features").WithValue(features).WithIsInline(true))
                .WithColor(Reference.OK_COLOR);

            if (Uri.IsWellFormedUriString(Context.Guild.IconUrl, UriKind.Absolute)) { embed.WithImageUrl(Context.Guild.IconUrl); }

            await Context.Channel.SendMessageAsync("test", false, embed, null).ConfigureAwait(false);
        }

        [Command("whois")]
        [RequireContext(ContextType.Guild)]
        public async Task Info(IGuildUser usr = null)
        {
            var user = usr ?? Context.User as IGuildUser;

            List<string> roles = new List<string>();

            if (user == null) return;

            foreach (ulong i in user.RoleIds) { roles.Add(user.Guild.GetRole(i).Name); }
            roles.Remove("@everyone");
            string r = string.Join(" ", roles);

            var embed = new EmbedBuilder().AddField(fb => fb.WithName("Username:").WithValue($"**{user.Username}**#{user.Discriminator}").WithIsInline(true));

            if (!string.IsNullOrWhiteSpace(user.Nickname))
            {
                embed.AddField(fb => fb.WithName("Nickname:").WithValue(user.Nickname).WithIsInline(true));
            }

            embed.AddField(fb => fb.WithName("User ID:").WithValue(user.Id.ToString()).WithIsInline(true))
                 .AddField(fb => fb.WithName("Joined On:").WithValue($"{user.JoinedAt?.ToString("dd.MM.yyyy HH:mm") ?? "?"}").WithIsInline(true))
                 .AddField(fb => fb.WithName("Created On:").WithValue($"{user.CreatedAt:dd.MM.yyyy HH:mm}").WithIsInline(true))
                 .AddField(fb => fb.WithName("Roles:").WithValue(r).WithIsInline(false))
                 .WithColor(Reference.OK_COLOR);

            if (user.AvatarId != null) { embed.WithThumbnailUrl(user.GetAvatarUrl()); }

            await Context.Channel.SendMessageAsync("", false, embed, null).ConfigureAwait(false);
        }
    }
}
