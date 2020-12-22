using System;

namespace CosmosKernel2
{
    public static class Kalkulator
    {
        public static void Addition()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float b = Convert.ToInt32(Console.ReadLine());

                float c = a + b;

                Console.Clear();
                Console.WriteLine("Suma = " + c);
            }
            catch (Exception e)
            {
                Log.Error(e.Message + "\n");
                Console.ReadKey();
                Addition();
            }
            
            Console.ReadKey();

            Console.Clear();
            System.Menu(true);
            
        }

        public static void Subtraction()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float b = Convert.ToInt32(Console.ReadLine());

                float c = a - b;

                Console.Clear();

                Console.WriteLine("Roznica = " + c);
            }
            catch (Exception e)
            {
                Log.Error(e.Message + "\n");
                Console.ReadKey();
                Subtraction();
            }

            Console.ReadKey();

            System.Menu(true);
        }

        public static void Multiplication()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float b = Convert.ToInt32(Console.ReadLine());

                float c = a * b;

                Console.Clear();

                Console.WriteLine("Iloczyn = " + c);
            }
            catch (Exception e)
            {
                Log.Error(e.Message + "\n");
                Console.ReadKey();
                Multiplication();
            }

            Console.ReadKey();

            System.Menu(true);
        }

        public static void Division()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float b = Convert.ToInt32(Console.ReadLine());

                float c = a / b;

                Console.Clear();

                Console.WriteLine("Iloraz = " + c);
            }
            catch (Exception e)
            {
                Log.Error(e.Message + "\n");
                Console.ReadKey();
                Division();
            }

            Console.ReadKey();

            System.Menu(true);
        }

        public static void Exponentiation()
        {
            try
            {
                Console.Write("Wpisz liczbe: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Do potegi?: ");
                int b = Convert.ToInt32(Console.ReadLine());

                double c = Math.Pow(a, b);

                Console.Clear();

                Console.WriteLine("Wynik = " + c);
            }
            catch (Exception e)
            {
                Log.Error(e.Message + "\n");
                Console.ReadKey();
                Exponentiation();
            }

            Console.ReadKey();

            System.Menu(true);
        }

        public static void Modulo()
        {
            try
            {
                Console.Write("Wpisz liczbe X: ");
                float a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wpisz liczbe Y: ");
                float b = Convert.ToInt32(Console.ReadLine());

                float c = a % b;

                Console.Clear();

                Console.WriteLine("Wynik = " + c);
            }
            catch (Exception e)
            {
                Log.Error(e.Message + "\n");
                Modulo();
            }

            Console.ReadKey();

            System.Menu(true);
        }
    }
}
