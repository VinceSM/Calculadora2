using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    public interface IOperation
    {
       decimal Operation(decimal num1, decimal num2);
    }
}
