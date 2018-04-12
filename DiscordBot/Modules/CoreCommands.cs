using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class CoreCommands : ModuleBase<SocketCommandContext>
    {
        private readonly DiscordSocketClient _client;

        [Command("ping")]
        public async Task Ping()
        {
            
        }

        [Command("help")]
        public async Task Help()
        {
            
        }

        [Command("stats")]
        public async Task Stats()
        {
            TimeSpan timeSinceStart = DateTime.Now.Subtract(Program.timeSinceStartup);

            //IDiscordClient embed => new RuntimeEmbed(new EmbedBuilder());
        }

        [Command("shard")]
        public async Task Shard()
        {

        }

        [Command("whois")]
        public async Task Info(IGuildUser usr = null)
        {
            var user = usr ?? Context.User as IGuildUser;

            List<string> roles = new List<string>();

            if (user == null) return;

            foreach (ulong i in user.RoleIds) { roles.Add(user.Guild.GetRole(i).Name); }
            roles.Remove("@everyone");
            string r = string.Join(" ", roles);

            var embed = new EmbedBuilder().AddField(fb => fb.WithName("Username:").WithValue($"**{user.Username}**#{user.Discriminator}").WithIsInline(true));

            if(!string.IsNullOrWhiteSpace(user.Nickname))
            {
                embed.AddField(fb => fb.WithName("Nickname:").WithValue(user.Nickname).WithIsInline(true));
            }

            embed.AddField(fb => fb.WithName("User ID:").WithValue(user.Id.ToString()).WithIsInline(true))
                 .AddField(fb => fb.WithName("Joined On:").WithValue($"{user.JoinedAt?.ToString("dd.MM.yyyy HH:mm") ?? "?"}").WithIsInline(true))
                 .AddField(fb => fb.WithName("Created On:").WithValue($"{user.CreatedAt:dd.MM.yyyy HH:mm}").WithIsInline(true))
                 .AddField(fb => fb.WithName("Roles:").WithValue(r).WithIsInline(false))
                 .WithColor(Reference.OK_COLOR);

            if(user.AvatarId != null) { embed.WithThumbnailUrl(user.GetAvatarUrl()); }

            await Context.Channel.SendMessageAsync("", false, embed, null).ConfigureAwait(false);
        }

        [Command("serverinfo")]
        public async Task Server(string guildName = null)
        {
            var channel = (ITextChannel)Context.Channel;
            guildName = guildName?.ToUpperInvariant();
            SocketGuild guild;

        }

        [Command("invite")]
        public async Task Invite()
        {
            await Context.Channel.SendMessageAsync("test Message");
            //e.Channel.QueueMessageAsync(locale.GetString("module_core_invite_message"));
            //await e.Author.QueueMessageAsync(locale.GetString("moudule_core_invite_dm") + "Replace with Config");
        }

        [Command("edit")]
        public async Task Edit()
        {

        }
    }

    [Group("prefix")]
    public class PrefixModule : ModuleBase
    {
        [Command]
        public async Task Prefix()
        {

        }

        [Command("default")]
        public async Task DefaultPrefix()
        {

        }

        [Command("change")]
        public async Task ChangePrefix()
        {

        }
    }

    [Group("invite")]
    public class InviteModule : ModuleBase
    {
        [Command]
        public async Task Invite()
        {
            
        }
    }

    [Group("group")]
    public class GroupModule : ModuleBase
    {
        [Command]
        public async Task Group()
        {

        }

        [Command("enable")]
        public async Task EnableGroup()
        {

        }

        [Command("disable")]
        public async Task DisableGroup()
        {

        }
    }
}
