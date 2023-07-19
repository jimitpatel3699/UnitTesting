using CalculatorTestingWithXUnnit;
using Xunit;

namespace CalculatorXunit.Test
{
    public class CalculatorNUniTest
    {
        [Fact]
        public void AddtionWithValidValues()
        {
            var calc = new Calculator();
            var actual = calc.Addition(2, 3);
            Assert.Equal(5, actual);
        }
        [Fact]
        public void SubtarctionWithValidValues()
        {

        }
    }
}