using System;

namespace CosmosKernel2
{
    public static class Menu
    {
        public static void ShowMenu(bool clear)
        {
            if (clear) Console.Clear();
            Console.WriteLine("Welcome To IT-DOS!");
            CommandPrompt.Prompt();
        }
    }
}
