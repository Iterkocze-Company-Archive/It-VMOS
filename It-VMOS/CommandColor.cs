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
                    Log.Error("\nNie ma takiego koloru.\n");
                    CommandPrompt.Prompt();
                }
                Console.ForegroundColor = (ConsoleColor)color;
            }
            else
            { 
                Console.WriteLine(
                    "0 - Czarny             8 - Ciemny szary \n" +
                    "1 - Ciemny niebieski   9 - niebieski \n" +
                    "2 - Ciemny zielony     10 - Zielony \n" +
                    "3 - Ciemny cyjan       11 - Cyjan \n" +
                    "4 - Ciemny czerwony    12 - Red \n" +
                    "5 - Fiolet             13 - Rozowy \n" +
                    "6 - Ciemny zolty       14 - Zolty \n" +
                    "7 - Szary              15 - Bialy \n");
                CommandPrompt.Prompt();
            }
        }
    }
}
