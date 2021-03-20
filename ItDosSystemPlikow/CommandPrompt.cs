using System;

namespace CosmosKernel2
{
    static public class CommandPrompt
    {
        public static void Prompt()
        {
            Console.Write("> ");
            string selectedFunction = Console.ReadLine();
            string[] function = selectedFunction.Split(" ");
            switch (function[0])
            {
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

                case "pomoc":
                    Console.WriteLine("calc, gry, benchmark, systeminfo, shutdown, reboot, pomoc, fcreate, dir, fdelete, cls, fopen, fedit, color, date");
                    break;

                case "systeminfo":
                    SystemInformation.Informacje_o_Systemie();
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
                    Log.Error("Nieznana komenda! Wpisz 'pomoc' aby wyswietlic liste komend.");
                    break;
            }
        Prompt();
        }
    }
}
