using Discord;
using Discord.Commands;
using DiscordBot.Managers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [ComVisible(false)]
    public class InformationModule : ModuleBase<SocketCommandContext>
    {
        private readonly CommandService _service;

        public InformationModule(CommandService service)
        {
            _service = service;
        }

        [Command("ping")]
        [Summary("Returns time taken to send message to bot server.")]
        public async Task Ping()
        {
            var sw = Stopwatch.StartNew();
            sw.Stop();
            await Context.Channel.SendMessageAsync($"{Format.Bold(Context.User.ToString())} PONG! {(int)sw.Elapsed.TotalMilliseconds}ms").ConfigureAwait(false);
        }

        [Command("prefix")]
        public async Task PrefixAsync()
        {
            string prefix = DatabaseManager.CheckGuildPrefix(Context.Guild.Id.ToString());
            await ReplyAsync($"Current set prefix is {prefix}");
        }

        [Command("help")]
        [Summary("Gives information on commands and their usages.")]
        public async Task HelpAsync()
        {
            //TODO IMPLEMENT HELP THAT DOES NOT CRASH
            await Context.Channel.SendMessageAsync("Seems like this command has not been completed. Better luck next time.");
        }

        [Command("help")]
        public async Task HelpAsync(string command)
        {
            var result = _service.Search(Context, command);

            if (!result.IsSuccess) { await ReplyAsync($"Sorry, I couldn't find a command like **{command}**!"); return; }

            var builder = new EmbedBuilder { Color = new Color(114, 137, 218), Description = $"Here are some commands like **{command}**!" };

            foreach(var match in result.Commands)
            {
                var cmd = match.Command;
                builder.AddField(x => { x.Name = string.Join(", ", cmd.Aliases); x.Value = $"Parameters: {string.Join(", ", cmd.Parameters.Select(p => p.Name))}\n" + $"Summary: {cmd.Summary}"; x.IsInline = false; });
            }

            await ReplyAsync("", false, builder.Build());
        }

        [Command("stats")]
        public async Task StatsAsync()
        {
            await Context.Channel.SendMessageAsync("Seems like this command has not been completed. Better luck next time.");
        }

        [Command("guildinfo"), Alias("serverinfo")]
        [Summary("Returns information about the current Guild or Server.")]
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
                .WithColor(114, 137, 218);

            if (Uri.IsWellFormedUriString(Context.Guild.IconUrl, UriKind.Absolute)) { embed.WithImageUrl(Context.Guild.IconUrl); }

            await Context.Channel.SendMessageAsync("", false, embed.Build(), null).ConfigureAwait(false);
        }

        [Command("whois"), Alias("user", "userinfo")]
        [Summary("Returns information about the current user, or the user parameter, if one passed.")]
        public async Task Info(IGuildUser usr)
        {
            var user = usr ?? Context.User as IGuildUser;

            List<string> roles = new List<string>();

            if (user == null) { return; }

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
                 .WithColor(114, 137, 218);

            if (user.AvatarId != null) { embed.WithThumbnailUrl(user.GetAvatarUrl()); }

            await Context.Channel.SendMessageAsync("", false, embed.Build(), null).ConfigureAwait(false);
        }
    }
}
