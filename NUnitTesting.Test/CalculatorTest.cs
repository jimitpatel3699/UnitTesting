using NUnit.Framework;
using CalculatorDemo;
using System.Collections.Generic;
using System.Globalization;

namespace NUnitTesting.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calculator;
        [SetUp]
        public void SetUp() 
        {   
            calculator= new Calculator();
        }
        [Test]
        public void TestAdditionWithValidValue()
        {
            var result = calculator.Addition(31 , 25);
            //verify actual result with expected result.
            Assert.AreEqual(56 , result);
        }
        [Ignore("Ignore Test")] 
        public void IgnoreTest()
        {
            //this test can be ignored.
        }
        [Test]
        public void TestAdditionWithInValidValue()
        {
            var result = calculator.Addition(12, 13);
            Assert.AreEqual (24 , result);
        }
        [Test]
        public void TestSubtractionWithvalidValue() 
        { 
            var result = calculator.Subtraction(15, 13);
            Assert.AreEqual(2, result);
        }
        [TestCase(1,2,2)]
        [TestCase(18,5,90)]
        [TestCase(36,45,458)]

        public void TestMultiplication(int first, int second, int expected )
        {
            var actual= calculator.Multiplication(first, second);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 3)]
        [TestCase(10, 4, 2.5)]
        [TestCase(11, 0, typeof(ArgumentException))]
        [TestCase(11, 0, 0)]
        public void TestDivision(float first, float second, object expected)
        {
            object actual;
            try
            {
                actual = calculator.Divide(first, second);
            }
            catch (Exception ex)
            {
                actual = ex.GetType();
            }

            Assert.AreEqual(expected, actual);
        }
        [TearDown]
        public void Teardown()
        {
            calculator.Dispose();
        }
    }
}