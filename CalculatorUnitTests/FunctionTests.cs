using Calculator;
using NUnit.Framework;

namespace CalculatorUnitTests
{
    public class FunctionTests
    {
        [Test]
        public void TwoIntegerSum()
        {
            // Initial Data
            int num1 = 5;
            int num2 = 5;
            int expectedValue = 10;

            // Actions
            int actualValue = Functions.Sum(num1, num2);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
