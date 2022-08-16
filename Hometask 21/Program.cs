using System;
using NUnit.Framework;


// 1. Unit-test a developed class of your choice.
//    Use at least two organizational structures
// 2. Use attributes testfixtures, test, testcase, setup
// 3. Create a test using mock
// 4. Try writing a fixture using TDD



namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    [TestFixture]
    class TestClass
    {
        [TestCase]
        public void AddTest()
        {

        }
    }

    namespace NUnit.Tests
    {
        using System;
        using NUnit.Framework;

        [TestFixture]
        public class SuccessTests
        {
            // ...
        }
    }
}