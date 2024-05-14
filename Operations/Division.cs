using Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operations
{
    internal class Division : IOperation
    {
        Calculator calculator;
        public decimal Operation()
        {
            if(calculator.Num1 == 0) { return num1 / num2; }
            else { throw new Exception("No se puede dividr por cero"); }
        }
    }
}
