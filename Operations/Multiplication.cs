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
        private decimal num1;
        private decimal num2;
        public decimal Operation()
        {
            return num1 * num2;
        }
    }
}
