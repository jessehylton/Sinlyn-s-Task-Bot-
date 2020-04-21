using System;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace BotApp.Commands
{
    [Group("admin")] // let's mark this class as a command group
    [Description("Administrative commands.")] // give it a description for help purposes
    [Hidden] // let's hide this from the eyes of curious users
    [RequirePermissions(Permissions.ManageGuild)] // and restrict this to users who have appropriate permissions


    public class Admin : BaseCommandModule
    {
        // all the commands will need to be executed as <prefix>admin <command> <arguments>



        [Command("kick"), Description("Gives someone a new nickname."), RequirePermissions(Permissions.BanMembers)]
        public async Task KickMember(CommandContext ctx, [Description("Ban an Asshole.")] DiscordMember member, [Description("Reason for kicking")] string rational)
        {
            // let's trigger a typing indicator to let
            // users know we're working
            await ctx.TriggerTypingAsync();

            try
            {
                await member.BanAsync(reason: rational);
                // let's make a simple response.
                var emoji = DiscordEmoji.FromName(ctx.Client, ":+1:");

                // and respond with it.
                await ctx.RespondAsync(emoji);
                await ctx.RespondAsync($"{member} the bastard is obliterated");
            }
            catch (Exception)
            {
                // oh no, something failed, let the invoker know
                var emoji = DiscordEmoji.FromName(ctx.Client, ":-1:");
                await ctx.RespondAsync(emoji);
                await ctx.RespondAsync($"Missed with your ban hammer, try better next time.");
            }

        }    
    
        
    }
    
}
