using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace Kiranti_TestBot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("ping")]
        [Description("Returns answer")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("answer").ConfigureAwait(false);
        }
        [Command("add")]
        [Description("Adds two numbers together")]
        public async Task add(CommandContext ctx,
            [Description("First number")]int numberOne,
            [Description("Second number")] int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne + numberTwo).ToString())
                .ConfigureAwait(false);
        }



    }
}
