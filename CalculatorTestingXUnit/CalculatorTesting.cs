using CalculatorforXUnit;
using Xunit;

namespace CalculatorTestingXUnit
{
    public class CalculatorTesting:IDisposable
    {
        private Calculator calculator;

        public CalculatorTesting()
        {
            calculator = new Calculator();
        }

        [Fact]
        public void TestAdditionWithValidValue()
        {
            var result = calculator.Addition(31, 25);
            Assert.Equal(56, result);
        }

        [Fact(Skip = "Ignore Test")]
        public void IgnoreTest()
        {
            // This test can be ignored.
        }

        [Fact]
        public void TestAdditionWithInValidValue()
        {
            var result = calculator.Addition(12, 13);
            Assert.Equal(24, result);
        }

        [Fact]
        public void TestSubtractionWithvalidValue()
        {
            var result = calculator.Subtraction(15, 13);
            Assert.Equal(2, result);
        }

        [InlineData(1, 2, 2)]
        [InlineData(18, 5, 90)]
        [InlineData(36, 45, 1620)]
        [Theory]
        public void TestMultiplication(int first, int second, int expected)
        {
            var actual = calculator.Multiplication(first, second);
            Assert.Equal(expected, actual);
        }

        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 3)]
        [InlineData(10, 4, 2.5)]
        [InlineData(11, 0, typeof(ArgumentException))]
        [InlineData(11, 0, 0)]
        [Theory]
        public void TestDivision(float first, float second, dynamic expected)
        {
            dynamic actual;
            try
            {
                 actual = calculator.Divide(first, second);
            }
            catch (Exception ex)
            {
                actual = ex.GetType();
            }

            Assert.Equal(expected, actual);
        }

        public void Dispose()
        {
            calculator.Dispose();
        }
    }
}