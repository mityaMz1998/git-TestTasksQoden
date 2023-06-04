using System;
using System.Collections.Generic;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int result = CalculatePostfix(input);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int CalculatePostfix(string[] expression)
        {
            List<int> list = new List<int>();

            foreach (var token in expression)
            {
                if (int.TryParse(token, out var b))
                {
                    list.Add(b);
                }
                else if (IsOperator(token))
                {
                    int operand2 = list[list.Count - 1];
                    int operand1 = list[list.Count - 2];
                    list.RemoveAt(list.Count - 1);
                    list.RemoveAt(list.Count - 1);
                    int result = PerformOperation(token, operand1, operand2);
                    list.Add(result);
                }
            }

            return list[0];
        }

        static bool IsOperator(string symbol)
        {
            return symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/";
        }

        static int PerformOperation(string operation, int operand1, int operand2)
        {
            switch (operation)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operation: " + operation);
            }
        }
    }
}
