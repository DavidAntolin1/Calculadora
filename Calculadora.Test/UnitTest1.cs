using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Operaciones.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            decimal n1 = 2;
            decimal n2 = 3;
            var s = Suma.Sum(n1, n2);
            Assert.AreEqual(5, s);
        }
        [TestMethod]
        public void TestSumaFail()
        {
            decimal n1 = 2;
            decimal n2 = 1;
            var s = Suma.Sum(n1, n2);
            Assert.AreNotEqual(s, 4);
        }
        [TestMethod]
        public void TestSubstract()
        {
            decimal n1 = 2;
            decimal n2 = 2;
            var s = Resta.Substract(n1, n2);
            Assert.AreEqual(s, 0);

        }
        [TestMethod]
        public void TestSubstractPositive()
        {
            decimal n1 = 1;
            decimal n2 = 4;
            var s = Resta.SubstractPositive(n1, n2);
            Assert.AreEqual(s, 3);
        }
        [TestMethod]
        public void TestMultiplication()
        {
            decimal n1 = 2;
            decimal n2 = 2;
            var s = Multiplicacion.Mult(n1,n2);
            Assert.AreNotEqual(s, 6);
        }
        [TestMethod]
        public void TestDivision()
        {
            decimal n1 = 2;
            decimal n2 = 1;
            var s = Division.Div(n1,n2);
            Assert.AreNotEqual(s, 3);
        }

       [TestMethod]
        public void TestPotency()
        {
            var s = Potencia.Potency(3, 2);
            Assert.AreNotEqual(s, 3);
        }
        [TestMethod]
        public void TestSqRoot()
        {
            var s = SqrRoot.SqRoot(-2);
            Assert.AreEqual(s, 4);
        }
    }
}
