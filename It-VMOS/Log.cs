using System;

namespace CosmosKernel2
{
    public static class Log
    {
        public static void Error(string s)
        {
            global::System.ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = global::System.ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ForegroundColor = previousColor;
        }
        public static void Info(string s)
        {
            global::System.ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = global::System.ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ForegroundColor = previousColor;
        }
        public static void Warn(string s)
        {
            global::System.ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = global::System.ConsoleColor.Yellow;
            Console.WriteLine(s);
            Console.ForegroundColor = previousColor;
        }
        public static void Suk(string s)
        {
            global::System.ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = global::System.ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ForegroundColor = previousColor;
        }
    }
}
