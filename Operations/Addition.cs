using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    internal class Addition : IOperation
    {
        private decimal num1 {  get; set; }
        private decimal num2 { get; set; }

        public decimal Operation()
        {
            return num1 + num2;
        }
    }
}
