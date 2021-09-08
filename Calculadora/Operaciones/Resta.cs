using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Operaciones
{
    public class Resta
    {
        public static decimal Substract(decimal n1, decimal n2)
        {
            return n1-n2;
        }
        public static decimal SubstractPositive(decimal n1, decimal n2)
        {
            decimal result = 0;
            if (n1 < n2)
            {
                result = n2 - n1;
            }
            else
            {
                result = n1 - n2;
            }
            
            return result;
        }
    }
}
