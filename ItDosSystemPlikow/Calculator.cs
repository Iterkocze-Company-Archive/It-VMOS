using System;
using System.Text;

namespace CosmosKernel2
{
    public static class Calculator
    {
        public static void CalcCore(string[] function)
        {
            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podane dzialanie.\n");
                CommandPrompt.Prompt();
            }

            char symbol = ' ';
            string equation = function[1];
            foreach (char ch in equation)
            {
                if (ch == '+' | ch == '-' | ch == '*' | ch == '/' | ch == '%' | ch == '^')
                {
                    symbol = ch;
                    break;
                }
            }
            if (symbol == ' ')
            {
                Log.Error("\nBrak znaku matematycznego w dzialaniu.\n");
                CommandPrompt.Prompt();
            }

            string[] numbers = equation.Split(new char[6] { '+', '-', '*', '/', '%', '^'});
            float result = 0;
            try
            {
                result = float.Parse(numbers[0]);
            }
            catch
            {
                Log.Error("\nW dzialaniu sa nieprawidlowe znaki\n");
                CommandPrompt.Prompt();
            }

            switch (symbol)
            {
                case '+':
                    result += float.Parse(numbers[1]);
                    break;
                case '-':
                    result -= float.Parse(numbers[1]);
                    break;
                case '*':
                    result = result * float.Parse(numbers[1]);
                    break;
                case '/':
                    result = result / float.Parse(numbers[1]);
                    break;
                case '%':
                    result = result % float.Parse(numbers[1]);
                    break;
                case '^':
                    try
                    {
                        float a = result;
                        for (int i = 1; i < Convert.ToInt32(numbers[1]); i++)
                        {
                            a = a * result;
                        }
                        result = a;
                    }
                    catch
                    {
                        Log.Error("\nNie mozna potegowac przez liczby niecalkowite.\n");
                        CommandPrompt.Prompt();
                    }
                    break;
            }

            Console.WriteLine($"wynik: {result}");
        }
    }
}
