using System;

namespace CosmosKernel2
{
    public static class Calculator
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

                Console.WriteLine("Suma = " + c);
            }
            catch (Exception e)
            {
                Log.Error("\n" + e.Message + "\n");
                Addition();
            }
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

                Console.WriteLine("Roznica = " + c);
            }
            catch (Exception e)
            {
                Log.Error("\n" + e.Message + "\n");
                Subtraction();
            }
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

                Console.WriteLine("Iloczyn = " + c);
            }
            catch (Exception e)
            {
                Log.Error("\n" + e.Message + "\n");
                Multiplication();
            }
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

                Console.WriteLine("Iloraz = " + c);
            }
            catch (Exception e)
            {
                Log.Error("\n" + e.Message + "\n");
                Division();
            }
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

                Console.WriteLine("Wynik = " + c);
            }
            catch (Exception e)
            {
                Log.Error("\n" + e.Message + "\n");
                Exponentiation();
            }
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

                Console.WriteLine("Wynik = " + c);
            }
            catch (Exception e)
            {
                Log.Error("\n" + e.Message + "\n");
                Modulo();
            }
        }
    }
}
