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
        public decimal Operation(decimal num1, decimal num2)
        {
            if(num2 != 0) 
            {
                decimal division = num1/num2;
                return division;
            }
            else { throw new Exception("No se puede dividr por cero"); }
        }
    }
}
