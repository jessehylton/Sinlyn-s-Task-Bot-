using System;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace BotApp.Commands
{
    public class Greet : BaseCommandModule
    {
        [Command("greet"), Description("Says hi to specified user."), Aliases("sayhi", "say_hi")]
        public async Task Greeting(CommandContext ctx, [Description("The user to say hi to.")] DiscordMember member) // this command takes a member as an argument; you can pass one by username, nickname, id, or mention
        {
            // note the [Description] attribute on the argument.
            // this will appear when people invoke help for the
            // command.

            // let's trigger a typing indicator to let
            // users know we're working
            await ctx.TriggerTypingAsync();

            // let's make the message a bit more colourful
            var emoji = DiscordEmoji.FromName(ctx.Client, ":relaxed:");


            // and finally, let's respond and greet the user.
            await ctx.RespondAsync($"{emoji} Hello, {member.Mention}, Welcome to {ctx.Guild.Name}! \n Where Waird is my friend.");
        }



    }
}
