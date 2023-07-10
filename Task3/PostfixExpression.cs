using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PostfixExpression : IPostfixExpression
    {
        public int CalculatePostfix(string[] expression)
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
        public bool IsOperator(string symbol)
        {
            return symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/";
        }

        public int PerformOperation(string operation, int operand1, int operand2)
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
