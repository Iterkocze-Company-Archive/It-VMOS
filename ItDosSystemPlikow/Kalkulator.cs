using System;

namespace CosmosKernel2
{
    public static class Kalkulator
    {
        public static void dodawanie()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float liczbaX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float liczbaY = Convert.ToInt32(Console.ReadLine());

                float suma = liczbaX + liczbaY;

                Console.Clear();
                Console.WriteLine("Suma = " + suma);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                dodawanie();
            }
            
            Console.ReadKey();

            Console.Clear();
            System.Menu(true);
            
        }

        public static void odejmowanie()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float liczbaX2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float liczbaY2 = Convert.ToInt32(Console.ReadLine());

                float roznica = liczbaX2 - liczbaY2;

                Console.Clear();

                Console.WriteLine("Roznica = " + roznica);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                dodawanie();
            }

            Console.ReadKey();

            Console.Clear();
            System.Menu(true);
        }

        public static void mnozenie()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float liczbaX3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float liczbaY3 = Convert.ToInt32(Console.ReadLine());

                float roznica = liczbaX3 * liczbaY3;

                Console.Clear();

                Console.WriteLine("Iloczyn = " + roznica);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                dodawanie();
            }

            Console.ReadKey();

            Console.Clear();
            System.Menu(true);
        }

        public static void dzielenie()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float liczbaX4 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float liczbaY4 = Convert.ToInt32(Console.ReadLine());

                float roznica = liczbaX4 / liczbaY4;

                Console.Clear();

                Console.WriteLine("Iloraz = " + roznica);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                dodawanie();
            }

            Console.ReadKey();

            Console.Clear();
            System.Menu(true);
        }

        public static void Potegowanie()
        {
            try
            {
                Console.Write("Wpisz liczbe: ");
                int liczbaX6 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Do potegi?: ");
                int liczbaY6 = Convert.ToInt32(Console.ReadLine());

                double modulo = Math.Pow(liczbaX6, liczbaY6);

                Console.Clear();

                Console.WriteLine("Wynik = " + modulo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                dodawanie();
            }

            Console.ReadKey();

            Console.Clear();
            System.Menu(true);
        }

        public static void Modulo()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float liczbaX5 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float liczbaY5 = Convert.ToInt32(Console.ReadLine());

                float potega = liczbaX5 % liczbaY5;

                Console.Clear();

                Console.WriteLine("Wynik = " + potega);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                dodawanie();
            }

            Console.ReadKey();

            Console.Clear();
            System.Menu(true);
        }
    }
}
