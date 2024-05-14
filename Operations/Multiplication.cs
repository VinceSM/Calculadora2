using Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operations
{
    internal class Multiplication : IOperation
    {
        public decimal Operation(decimal num1, decimal num2)
        {
            decimal multi =  num1 * num2;
            return multi;
        }
    }
}
