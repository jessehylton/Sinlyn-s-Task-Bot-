using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace BotApp.Commands
{
    public class Dice : BaseCommandModule
    {
        [Command("roll"), Description("Roll, roll a die ")]
        public async Task Random(CommandContext ctx, int max)
        {
            var rnd = new Random(DateTimeOffset.Now.Millisecond);

            await ctx.RespondAsync($"🎲 Your roll is: {rnd.Next(1, max + 1)}");
        }


        [Command("mroll"), Description("Multiroll, roll more than one die ")]
        public async Task MultRandom(CommandContext ctx, [Description("Number of Dice")] int numOfDice, [Description("Number of sides")] int sides)
        {
            List<int> rolls = new List<int>();

            var stop = 0;
            var rnd = new Random(DateTimeOffset.Now.Millisecond); // Sets up the random generator using milliseconds as a token.


            while (stop < numOfDice) //repeats dice rolls
            {
                var result = rnd.Next(1, sides + 1); // rolling the dice.

                rolls.Add(result); //adds new result to list

                stop++;
            }

            var total = rolls.Sum(); //Sum from all the rolls in the list

            //Response

            await ctx.TriggerTypingAsync();

            await ctx.RespondAsync(":vertical_traffic_light:` Your rolls are: `");
            await ctx.RespondAsync($">>> {string.Join(" , ", rolls)}");//Converts and displays the list as a string
            await ctx.RespondAsync($"\n` The total is : {total} `");
        }

    }
}

/*
      Concepts used there that are different than yours:
       * -tuples
       * -LINQ
       * -lambdas
       * -expressions > statements
       * rather than tackling all at once, you can break things down into those four pieces to learn more

      [WARNING:] Code below does break easy reading and easy comprehension principles.

      [Command("mroll"), Description("Multiroll, roll more than one die ")]
      public async Task MultRandom(CommandContext ctx, [Description("Number of Dice")] int numOfDice, [Description("Number of sides")] int sides)
      {
          var (rolls, total) = Enumerable.Range(1, numOfDice).Aggregate(((IEnumerable<int>)new List<int>(), new Random(DateTimeOffset.Now.Millisecond)), (acc, next) =>
              (acc.Item1.Append(acc.Item2.Next(1, sides + 1)), acc.Item2),
              (acc => (acc.Item1, acc.Item1.Sum())));

          //Response

          await ctx.TriggerTypingAsync();

          await ctx.RespondAsync(":vertical_traffic_light:` Your rolls are: `");
          await ctx.RespondAsync($">>> {string.Join(" , ", rolls)}");//Converts and displays the list as a string
          await ctx.RespondAsync($"\n` The total is : {total} `");
      } */
