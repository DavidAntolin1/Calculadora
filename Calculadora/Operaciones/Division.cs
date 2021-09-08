using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Operaciones
{
    public class Division
    {
        public static decimal Div(decimal n1, decimal n2)
        {
            return n1/n2;
        }

        public static decimal DivNoZero(decimal[] l)
        {

            decimal result = 0;
            foreach (decimal item in l)
            {
                if (item == 0)
                {
                    throw new DivideByZeroException();
                }
                result /= item;
            }
            return result;
        }
    }
}
