using NUnit.Framework;
using System;

namespace SampleProject.learnSelenium
{
    [TestFixture]
    class _2_NUnit
    {
        [Test]
        public void MyFirstTest()
        {
            Console.WriteLine("Ran MyFirstTest");
        }

        [Test]
        public void MySecondTest()
        {
            Console.WriteLine("Ran MySecondTest");
        }

        [Test]
        public void MyThirdTest()
        {
            Console.WriteLine("Ran MyThirdTest");
        }





        [SetUp]
        public void BeforeEveryTest()
        {
            Console.WriteLine("Before Every Test");
        }

        [TearDown]
        public void AfterEveryTest()
        {
            Console.WriteLine("After Every Test");
        }





        [OneTimeSetUp]
        public static void BeforeFirstTest()
        {
            Console.WriteLine("Before First Test");
        }

        [OneTimeTearDown]
        public static void AfterLastTest()
        {
            Console.WriteLine("Affter Last Test");
        }
    }
}
