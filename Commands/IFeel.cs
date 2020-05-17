using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace BotApp.Commands
{
    [Group("ifeel")] // let's mark this class as a command group
    [Aliases("feeling", "feelinglike", "im", "ifeellike")]
    [Description("express your feelings with GIFs")] // give it a description for help purposes

    class IFeel : BaseCommandModule
    {
        [GroupCommand]
        public async Task RandomFeelingAsync(CommandContext ctx)
        {
            // let's give them a random meme
            var rnd = new Random();
            var nxt = rnd.Next(0, 3);

            switch (nxt)
            {
                case 0:
                    await Crying(ctx);
                    return;

                case 1:
                    await happy(ctx);
                    return;

                case 2:
                    await Mad(ctx);
                    return;
                case 3:
                    await Scared(ctx);
                    return;
               
            }
        }

        [Command("fuckable"), Description("NSFW GIF involving sex"), Hidden, RequireNsfw]
        public async Task Fuckable(CommandContext ctx)
        {
            var rnd = new Random();
            var fuck  = rnd.Next(0, 3);

            switch (fuck)
            {
                case 0:

                    return;

                case 1:

                    return;

                case 2:

                    return;
                case 3:

                    return;
            }
        }

        [Command("sad"), Description("aww... :("), Aliases("crying","hurt")]
        public async Task Crying(CommandContext ctx)
        {
            var rnd = new Random();
            var sad = rnd.Next(0, 3);

            switch (sad)
            {
                case 0:

                    return;

                case 1:

                    return;

                case 2:

                    return;
                case 3:

                    return;
            }

        }

        [Command("happy"), Description(""), Aliases("content", "nice")]
        public async Task happy(CommandContext ctx)
        {
            var rnd = new Random();
            var happy = rnd.Next(0, 3);

            switch (happy)
            {
                case 0:

                    return;

                case 1:

                    return;

                case 2:

                    return;
                case 3:

                    return;
            }

        }

        [Command("mad"), Description("mad! D:<"), Aliases("pissedoff","angry")]
        public async Task Mad(CommandContext ctx)
        {
            var rnd = new Random();
            var mad = rnd.Next(0, 3);

            switch (mad)
            {
                case 0:

                    return;

                case 1:

                    return;

                case 2:

                    return;
                case 3:

                    return;
            }
           
        }

        [Command("scared"), Description("AHHH!!! D:"), Aliases("afraid","spooked","skiddish","scardycat","frieghtened","terrified")]
        public async Task Scared(CommandContext ctx)
        {
            var rnd = new Random(DateTimeOffset.Now.Millisecond);
            var scared = rnd.Next(0, 3);
           

            switch (scared)
            {
                case 0:
                    var embed = new DiscordEmbedBuilder
                    {
                       
                        ImageUrl = "https://media.giphy.com/media/igi0dS20WxPJvroIgW/source.gif"
                    };
                    await ctx.TriggerTypingAsync();
                    await ctx.RespondAsync($"{ctx.User.Mention} is scared!");
                    await ctx.RespondAsync(embed: embed);
                    return;

                case 1:
                    var embed1 = new DiscordEmbedBuilder
                    {
                        
                        ImageUrl = "https://media.giphy.com/media/2gG2xiMTtFwsg/source.gif"
                    };
                    await ctx.TriggerTypingAsync();
                    await ctx.RespondAsync($"{ctx.User.Mention} is scared!");
                    await ctx.RespondAsync(embed: embed1);
                    return;

                case 2:
                    var embed2 = new DiscordEmbedBuilder
                    {
                        
                        ImageUrl = "https://media.giphy.com/media/4YY3EsQbp7r14bJdDP/source.gif"
                    };
                    await ctx.TriggerTypingAsync();
                    await ctx.RespondAsync($"{ctx.User.Mention} is scared!");
                    await ctx.RespondAsync(embed: embed2);
                    return;
                case 3:
                    var embed3 = new DiscordEmbedBuilder
                    {
                        
                        ImageUrl = "https://media.giphy.com/media/KmTnUKop0AfFm/source.gif"
                    };
                    await ctx.TriggerTypingAsync();
                    await ctx.RespondAsync($"{ctx.User.Mention} is scared!");
                    await ctx.RespondAsync(embed: embed3);
                    return;
            }

        }
        public async Task ScaredResponse(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync($"{ctx.User.Mention} is scared!");
            await ctx.RespondAsync(embed: embed);
        }
    }
}
