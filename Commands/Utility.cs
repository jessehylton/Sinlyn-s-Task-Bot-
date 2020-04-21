using DSharpPlus.CommandsNext;
using DSharpPlus;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotApp.Commands
{
    [Group("mod")]
    [Description("Stuff for the mods to use.")]
    [Hidden]
    [RequirePermissions(Permissions.ManageGuild)]
    public class Utility : BaseCommandModule
    {


        [Command("guildinfo")]
        [Aliases("serverinfo")]
        [Description("Get some info about this guild")]
        public async Task GuildInfo(CommandContext ctx)
        {
            var emb = new DiscordEmbedBuilder();
            emb.WithTitle(ctx.Guild.Name);
            emb.WithColor(new DiscordColor(0212255));
            emb.WithThumbnailUrl(ctx.Guild.IconUrl);
            emb.AddField("Owner", ctx.Guild.Owner.Mention, true);
            emb.AddField("ID", ctx.Guild.Id.ToString(), true);
            emb.AddField("Created At", ctx.Guild.CreationTimestamp.ToString(), true);
            emb.AddField("Emojis", ctx.Guild.Emojis.Count.ToString(), true);
            await ctx.RespondAsync(embed: emb.Build());
        }

        [Command("kick")]
        [Aliases("goaway")]
        [Description("For kicking bastards out of the server")]
        public async Task Kick(CommandContext ctx, [Description("The user to say fuck off to.")] DiscordMember member)

        {
            await ctx.TriggerTypingAsync();

            await member.RemoveAsync(reason: $"{ctx.User.Username} has kicked ({ctx.User.Id}).");

            var emoji = DiscordEmoji.FromName(ctx.Client, ":relaxed:");

            await ctx.RespondAsync(emoji);
            await ctx.RespondAsync($" {ctx.User.Username} has kicked ({ctx.User.Id}) like sparta. ");
        }

    }
}
