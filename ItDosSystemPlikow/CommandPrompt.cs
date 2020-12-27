using System;
using Cosmos.System.FileSystem.Listing;

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

                case "pomoc":
                    Console.WriteLine("kalkulator, grap, gry, benchmark, systeminfo, shutdown, reboot, pomoc, fcreate, dir, fdelete, cls, fopen, fedit");
                    break;

                case "grap":
                    TestGrafiki TG = new TestGrafiki();
                    TG.Pulpit();
                    Console.ReadKey();
                    break;

                case "systeminfo":
                    InformacjeSystem.Informacje_o_Systemie();
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
                    SystemPlikow.Dir(function);
                    break;

                case "fcreate":
                    SystemPlikow.StworzPlik(function);
                    break;

                case "fdelete":
                    SystemPlikow.UsunPlik(function);
                    break;

                case "cls":
                    Console.Clear();
                    break;

                case "fopen":
                    SystemPlikow.OtworzPlik(function);
                    break;

                case "fedit":
                    SystemPlikow.EdytujPlik(function);
                    break;
                    
                default:
                    Log.Error("Nieznana komenda! Wpisz 'pomoc' aby wyswietlic liste komend.");
                    break;
            }
        Prompt();
        }
    }
}
