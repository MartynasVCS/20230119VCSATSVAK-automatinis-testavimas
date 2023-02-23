using Calculator;
using NUnit.Framework;

namespace UnitTests
{
    public class CalculatorFunctionTests
    {
        [Test]
        public void Sum_5_5_Int()
        {
            // Initial Data
            int num1 = 5;
            int num2 = 5;
            int expectedValue = 10;

            // Actions
            int actualValue = Functions.Sum_Int(num1, num2);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Difference_10_5_Int()
        {
            int expectedValue = 5;
            int num1 = 10;
            int num2 = 5;

            int actualValue = Functions.Difference(num1, num2);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Division_10_3_Double()
        {
            double expectedValue = 3.33333333333333d;
            int num1 = 10;
            int num2 = 3;

            double actualValue = Functions.Division_Double(num1, num2);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Division_10_3_Double_Rounded()
        {
            double expectedValue = 3.333333d;
            int num1 = 10;
            int num2 = 3;

            double actualValue = Functions.Division_Double_Rounded(num1, num2);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Division_10_4_Double()
        {
            double expectedValue = 2.5d;
            int num1 = 10;
            int num2 = 4;

            double actualValue = Functions.Division_Double(num1, num2);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Division_10_3_Decimal()
        {
            decimal expectedValue = 3.3333333333333333333333333333m;
            int num1 = 10;
            int num2 = 3;

            decimal actualValue = Functions.Division_Decimal(num1, num2);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Sum_01_01_Double()
        {
            double expectedValue = 0.2d;
            double num1 = 0.1;
            double num2 = 0.1;

            double actualValue = Functions.Sum_Double(num1, num2);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Sum_01_01_01_Double()
        {
            double expectedValue = 0.3d;
            double num1 = 0.1d;
            double num2 = 0.1d;
            double num3 = 0.1d;

            double actualValue = Functions.Sum_Double_3(num1, num2, num3);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Sum_01_01_01_Decimal()
        {
            decimal expectedValue = 0.3m;
            decimal num1 = 0.1m;
            decimal num2 = 0.1m;
            decimal num3 = 0.1m;

            decimal actualValue = Functions.Sum_Decimal_3(num1, num2, num3);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
