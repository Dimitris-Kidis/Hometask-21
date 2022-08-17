using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    [TestFixture]
    class EquationTests
    {
        private int setUpVar;

        [TestCase(1, 1, 1)]
        [TestCase(1, 5, 1)]
        [TestCase(7, 1, 8)]
        [Test]
        public void CheckSQRTPartReturnsInt(int a, int b, int c)
        {
            Equation eq = new Equation();
            int result = eq.CheckSQRTPart(a, b, c);
            Assert.AreEqual(-1, result);
        }

        [TestCase("XXXII")]
        [TestCase("VI")]
        [Test]
        public void CheckConversionReturnsInt(string str)
        {
            Equation eq1 = new Equation();
            int result = eq1.RomanToInteger(str);
            Assert.AreEqual(6, result);
        }


        [Test]
        public void CheckRandomNumTest()
        {
            int result = new Random().Next(4, 7);
            Assert.AreEqual(setUpVar, result);
        }

        [SetUp]
        public void Init()
        {
            setUpVar = 5;
        }

    }
}
