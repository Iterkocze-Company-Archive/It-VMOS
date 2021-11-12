using System;

namespace CosmosKernel2
{
    public static class CommandColor
    {
        public static void ColorChanger(string[] function)
        {
            if (function.Length > 1)
            {
                int color = 0;
                try
                {
                    color = Convert.ToInt32(function[1]);
                }
                catch
                {
                    Log.Error("\nThere is no such color.\n");
                    CommandPrompt.Prompt();
                }
                Console.ForegroundColor = (ConsoleColor)color;
            }
            else
            { 
                Console.WriteLine(
                    "0 - Dark           8 - Dark Gray \n" +
                    "1 - Dark Blue      9 - Blue \n" +
                    "2 - Dark Green     10 - Green \n" +
                    "3 - Dark Cyan      11 - Cyan \n" +
                    "4 - Dark Red       12 - Red \n" +
                    "5 - Violet         13 - Pink \n" +
                    "6 - Dark Yellow    14 - Yellow \n" +
                    "7 - Gray           15 - White \n");
                CommandPrompt.Prompt();
            }
        }
    }
}
