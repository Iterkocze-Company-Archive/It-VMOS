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
                Log.Error("\nYou Must Give a Operation.\n");
                CommandPrompt.Prompt();
            }

            string[] numbers = function[1].Split(new char[6] { '+', '-', '*', '/', '%', '^' });
            float result = 0;
            try
            {
                result = float.Parse(numbers[0]);
            }
            catch
            {
                Log.Error("\nThere Are Invalid Characters In The Operation\n");
                CommandPrompt.Prompt();
            }

            char symbol = ' ';
            foreach (char ch in function[1])
            {
                if (ch == '+' | ch == '-' | ch == '*' | ch == '/' | ch == '%' | ch == '^')
                {
                    symbol = ch;
                    break;
                }
            }
            if (symbol == ' ')
            {
                Log.Error("\nThere Is No Operation Provided.\n");
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
                        Log.Error("\nYou Cannot Exponentiate non-integers.\n");
                        CommandPrompt.Prompt();
                    }
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
