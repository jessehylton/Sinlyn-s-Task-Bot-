using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace BotApp.Commands
{
    public class Dice
    {
        [Command("roll")]


        public async Task Random(CommandContext ctx, int max)
        {
            var rnd = new Random(DateTime.Now.Millisecond);

            await ctx.RespondAsync($"🎲 Your roll is: {rnd.Next(max++)}");
        }
       [Command("multiroll")]

        public async Task MultRandom(CommandContext ctx, int mod, int max)
        {
            int stop = mod + mod;

            while (mod < stop)
            {
                var rnd = new Random(DateTime.Now.Millisecond);

                await ctx.RespondAsync($"🎲 Your roll is: {rnd.Next(max++)}");
                mod++;
            }
        }
    }
}