using System;
using Cosmos.System.FileSystem.Listing;

namespace CosmosKernel2
{
    static public class CommandPrompt
    {
        public static void Prompt()
        {
            global::System.Console.Write("> ");
            string selectedFunction = global::System.Console.ReadLine();
            string[] function = selectedFunction.Split(" ");
            switch (function[0])
            {
                case "kalkulator":
                    Console.Clear();
                    
                    Console.WriteLine("1 - Dodawanie");
                    Console.WriteLine("2 - Odejmowanie");
                    Console.WriteLine("3 - Mnozenie");
                    Console.WriteLine("4 - Dzielenie");
                    Console.WriteLine("5 - Potegowanie");
                    Console.WriteLine("6 - Dzielenie z reszta");
                    string wyborFunkcjiK = global::System.Console.ReadLine();
                    switch (wyborFunkcjiK)
                    {
                        case "1":
                        case "dodawanie":
                            Calculator.Addition();
                            break;

                        case "2":
                        case "odejmowanie":
                            Calculator.Subtraction();
                            break;

                        case "3":
                        case "mnozenie":
                            Calculator.Multiplication();
                            break;

                        case "4":
                        case "dzielenie":
                            Calculator.Division();
                            break;
                        case "5":
                        case "potegowanie":
                            Calculator.Exponentiation();
                            break;
                        case "6":
                        case "dzielenie z reszta":
                            Calculator.Modulo();
                            break;
                    }
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
