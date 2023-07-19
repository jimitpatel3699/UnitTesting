using CalculatorforXUnit;
using Xunit;

namespace CalculatorTestingXUnit
{
    public class CalculatorTesting
    {
        [Fact]
        public void TestAdditionWithInValidValue()
        {
            var calculator = new Calculator();
            var result = calculator.Addition(12, 13);
            Assert.Equal(25, result);
        }
    }
}