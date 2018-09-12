using System;
using System.Threading.Tasks;

namespace DiscordBotCore
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");
            await MyWeirdTask();
        }

        private static async Task MyWeirdTask()
        {
            Console.WriteLine("Oh yea, there it is.");
            await Task.Delay(-1);
        }
    }
}