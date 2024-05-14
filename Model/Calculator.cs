using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    internal class Calculator
    {
        IOperation Operation;
        public decimal Num1;
        public decimal Num2;

        public Calculator(IOperation operation, decimal num1, decimal num2)
        {
            this.Operation = operation;
            Num1 = num1;
            Num2 = num2;
        }
    }
}
