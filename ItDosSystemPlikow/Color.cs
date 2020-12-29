using System;

namespace CosmosKernel2
{
    public static class Color
    {
        public static void ColorChanger(string[] function)
        {
            string inpColor = function[1];
            bool isColor = false;
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            if (Char.IsLower(function[1][0]))
            {
                char[] chArr = function[1].ToCharArray();
                chArr[0] = Char.ToUpper(chArr[0]);
                inpColor = new string(chArr);
            }

            foreach (ConsoleColor color in colors)
            {
                if ((ConsoleColor)Enum.Parse(typeof(ConsoleColor), inpColor) == color) isColor = true;
            }
            if (!isColor)
            {
                Log.Error("\nNie ma takiego koloru.\n");
                CommandPrompt.Prompt();
            }

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), inpColor);
        }
    }
}
