﻿using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
namespace BotApp.Commands
{

    public class Insult : BaseCommandModule
    {

        [Command("insult")]
        public async Task Insults(CommandContext burn)
        {
            var rnd = new Random();
            int InsultSelector = rnd.Next(1, 5);


            switch (InsultSelector)
            {
                case 1:
                    await burn.RespondAsync($"Your mother is a hamster and your father smells like elderbarries");
                    break;
                case 2:
                    await burn.RespondAsync($"You can't bing because you can't bong");
                    break;
                case 3:
                    await burn.RespondAsync($"Your mom is small brain bing bong!");
                    break;
                case 4:
                    await burn.RespondAsync($"You think you enderman? Well you smell like enderman hehe!");
                    break;

            }


        }
    }
}
