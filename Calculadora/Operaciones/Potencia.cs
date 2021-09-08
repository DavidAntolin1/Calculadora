using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Operaciones
{
    public class Potencia
    {
        public static int Potency(int n1, int n2)
        {
            int result = 0;
            result =(int)Math.Pow(n1, n2);
            result = n1 ^ n2;
            return result;
        }

    }
}
