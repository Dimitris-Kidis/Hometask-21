using System;
using App;
using Moq;
using NUnit.Framework;


// 1. Unit-test a developed class of your choice ✅
// 2. Use attributes testfixtures, test, testcase, setup ✅
// 3. Create a test using mock ✅
// 4. Try writing a fixture using TDD ✅



namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            Automobile carOne = new Automobile(new SmallEngine());
            Automobile carTwo = new Automobile(new BigEngine());


    
            carOne.TurnOn();
            carTwo.TurnOn();
        }

        [Test]
        public void ItShouldCreateCars()
        {
            var mockEngine = new Mock<IEngine>();
            var automobile = new Automobile(mockEngine.Object);

            automobile.TurnOn();

            mockEngine.Verify();
        }
    }

}

