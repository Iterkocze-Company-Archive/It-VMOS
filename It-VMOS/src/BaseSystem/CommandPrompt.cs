using System;
using System.Collections.Generic;

namespace CosmosKernel2
{
    static public class CommandPrompt
    {
        private static List<string> LastCommands = new List<string>();
        private static int index = 0;
        public static void Prompt()
        {
            Console.Write("> ");
            string selectedFunction = Console.ReadLine();
            LastCommands.Add(selectedFunction);
            string[] function = selectedFunction.Split(" ");
            switch (function[0].ToLower())
            {
                case "up":
                    Console.WriteLine(LastCommands[index]);
                    index++;
                    break;

                case "down":
                    index--;
                    if (index >= 0) Console.WriteLine(LastCommands[index]);
                    break;

                case "calculator":
                case "calc":
                    Calculator.CalcCore(function);
                    break;

                case "date":
                    DateTime date = DateTime.Today;
                    Console.WriteLine($"{date.Day}/{date.Month}/{date.Year}");
                    break;

                case "echo":
                    Console.WriteLine(function[1]);
                    break;

                case "help":
                    Help.ShowHelp();
                    break;

                case "systeminfo":
                    SystemInformation.Show();
                    break;

                case "benchmark":
                    Benchmark b1 = new Benchmark();
                    b1.BenchmarkGO();
                    break;

                case "linus112":
                    Linus112.Linus();
                    break;

                case "shutdown":
                    Cosmos.System.Power.Shutdown();
                    break;

                case "reboot":
                    Cosmos.System.Power.Reboot();
                    break;

                case "dir":
                    FileSystemCommands.Dir(function);
                    break;

                case "fcreate":
                    FileSystemCommands.Fcreate(function);
                    break;

                case "fdelete":
                    FileSystemCommands.Fdelete(function);
                    break;

                case "clear":
                case "cls":
                    Console.Clear();
                    break;

                case "fopen":
                    FileSystemCommands.Fopen(function);
                    break;

                case "fedit":
                    FileSystemCommands.Fedit(function);
                    break;

                case "color":
                    CommandColor.ColorChanger(function);
                    break;
                    
                default:
                    Log.Error("Unknown Command! Type 'help' for command list.");
                    break;
            }
        Prompt();
        }
    }
}
