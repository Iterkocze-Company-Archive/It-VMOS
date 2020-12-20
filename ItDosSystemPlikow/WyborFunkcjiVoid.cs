using System;

namespace CosmosKernel2
{
    static public class WyborFunkcjiVoid
    {
        public static void wyborFunkcjiVoid()
        {
            Console.Write("> ");
            string selectedFunction = Console.ReadLine();
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
                    string wyborFunkcjiK = Console.ReadLine();
                    switch (wyborFunkcjiK)
                    {
                        case "1":
                        case "dodawanie":
                            Kalkulator.dodawanie();
                            break;

                        case "2":
                        case "odejmowanie":
                            Kalkulator.odejmowanie();
                            break;

                        case "3":
                        case "mnozenie":
                            Kalkulator.mnozenie();
                            break;

                        case "4":
                        case "dzielenie":
                            Kalkulator.dzielenie();
                            break;
                        case "5":
                        case "potegowanie":
                            Kalkulator.Potegowanie();
                            break;
                        case "6":
                        case "dzielenie z reszta":
                            Kalkulator.Modulo();
                            break;
                    }
                    break;

                case "pomoc":
                    Console.Clear();
                    Console.WriteLine("kalkulator, grap, gry, benchmark, systeminfo, shutdown, reboot, pomoc, fcreate, dir, fdelete, cls, fopen, fedit");
                    Console.ReadKey();
                    Console.Clear();
                    System.Menu(true);
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
                    SystemPlikow.StworzPlik();
                    break;

                case "fdelete":
                    SystemPlikow.UsunPlik();
                    break;

                case "cls":
                    Console.Clear();
                    break;

                case "fopen":
                    SystemPlikow.OtworzPlik();
                    break;

                case "fedit":
                    SystemPlikow.EdytujPlik();
                    break;
                    
                default:
                    Log.Error("Nieznana komenda! Wpisz 'pomoc' aby wyswietlic liste komend.");
                    break;
            }
        wyborFunkcjiVoid();
        }
    }
}
