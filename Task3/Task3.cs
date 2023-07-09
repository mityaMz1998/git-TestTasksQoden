using System;
using System.Collections.Generic;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {          
            PostfixExpression postfixExpression = new PostfixExpression(); 
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int result = postfixExpression.CalculatePostfix(input);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
