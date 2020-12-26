using System;

namespace CosmosKernel2
{
    class Log
    {
        public static void Error(string s)
        {
            global::System.Console.ForegroundColor = ConsoleColor.Red;
            global::System.Console.WriteLine(s);
            global::System.Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Info(string s)
        {
            global::System.Console.ForegroundColor = ConsoleColor.Blue;
            global::System.Console.WriteLine(s);
            global::System.Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Warn(string s)
        {
            global::System.Console.ForegroundColor = ConsoleColor.Yellow;
            global::System.Console.WriteLine(s);
            global::System.Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Suk(string s)
        {
            global::System.Console.ForegroundColor = ConsoleColor.Green;
            global::System.Console.WriteLine(s);
            global::System.Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
