using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitsu.Anime;
using Kitsu.Manga;
using Kitsu;

namespace BotApp.Commands
{
    class Utility
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

    }
}
