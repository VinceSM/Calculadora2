using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    internal class Addition : IOperation
    {

        public decimal Operation(decimal num1, decimal num2)
        {
            decimal suma = num1 + num2;
            return suma;
        }
    }
}
