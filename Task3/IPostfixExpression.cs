using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface IPostfixExpression
    {
        int CalculatePostfix(string[] expression);
        bool IsOperator(string symbol);
        int PerformOperation(string operation, int operand1, int operand2);
    }
}
