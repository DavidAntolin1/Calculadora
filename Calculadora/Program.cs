using Calculadora.Operaciones;
using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = 2;
            decimal n2 = 1;
            double d1 = 9;
            double d2 = 2;
            decimal[] l = { 2, -1, 2 };

            Console.WriteLine(Division.Div(n1, n2));
            Console.WriteLine(Division.DivNoZero(l));
            Console.WriteLine(Suma.Sum(n1, n2));
            Console.WriteLine(Suma.SumaMultiple(l));
            Console.WriteLine(Resta.Substract(n1, n2));
            Console.WriteLine(Resta.SubstractPositive(n1, n2));
            Console.WriteLine(Multiplicacion.Mult(n1, n2));
            Console.WriteLine(SqrRoot.SqRoot(d1));
            Console.WriteLine(Potencia.Potency(2, 3));

//            Console.WriteLine(@"
//Titulo
//    Menu
//        1.A
//        2.B
//");
        }
    }
}
