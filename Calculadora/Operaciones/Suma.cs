using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Operaciones
{
    public class Suma
    {   
        public static decimal Sum(decimal n1,decimal n2)
        {
            return n1+n2;
        }

        public static decimal SumaMultiple(decimal[] l)
        {
            decimal result = 0;
            foreach (var item in l)
            {
                result += item;
            }
            return result;
        }
    }
}
