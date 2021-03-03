using System;

namespace Kiranti_TestBot
{
    class Program
    {
        static void Main(string[] args)
        {

            var bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
