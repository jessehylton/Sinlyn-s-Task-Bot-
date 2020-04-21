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
    public class Dice : BaseCommandModule
    {
        [Command("roll"), Description("Roll, roll a die ")]
        public async Task Random(CommandContext ctx, int max)
        {
            var rnd = new Random(DateTimeOffset.Now.Millisecond);

            await ctx.RespondAsync( $"🎲 Your roll is: {rnd.Next(1, max + 1)}");
        }

        [Command("mroll"), Description("Multiroll, roll more than one die ")]
        public async Task MultRandom(CommandContext ctx, [Description("Number of Dice")] int numOfDice, [Description("Number of sides")] int sides)
        {
            List<int> rolls = new List<int>();
            
            var stop = 0;
            var rnd = new Random(DateTimeOffset.Now.Millisecond);

            while (stop < numOfDice) 
            {
                var result = rnd.Next(1,sides+1);
               
                rolls.Add(result);

                stop++;
            }

            var total = rolls.Sum();
         //Response
            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync(":vertical_traffic_light:` Your rolls are: `");
            await ctx.RespondAsync($">>> {string.Join(" , ", rolls)}");
            await ctx.RespondAsync($"\n` The total is : {total} `");
        }
    }
}