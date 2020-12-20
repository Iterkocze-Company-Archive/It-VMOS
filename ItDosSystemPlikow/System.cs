using System;

namespace CosmosKernel2
{
    public static class System
    {
        public static void Menu(bool clear)
        {
            if (clear)
            {
                Console.Clear();
            }
            Console.WriteLine("Witaj w Systemie IT-DOS!");
            WyborFunkcjiVoid.wyborFunkcjiVoid();
        }
    }
}
