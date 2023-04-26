using net_calculator_tester;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(8.2f, 2.8f, 11.0f)]
        public void TestAdd(float num1, float num2, float expected)
        {
            // Assert
            Assert.That(Calculator.Add(num1, num2), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(9.2f, 4.2f, 5.0f)]
        public void TestSubtract(float num1, float num2, float expected)
        {
            // Assert
            Assert.That(Calculator.Subtract(num1, num2), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(8.0f, 2.0f, 4.0f)]
        public void TestDivide(float num1, float num2, float expected)
        {
            // Assert
            Assert.That(Calculator.Divide(num1, num2), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(8.2f, 2.8f, 22.96f)]
        public void TestMultiply(float num1, float num2, float expected)
        {
            // Assert
            Assert.That(Calculator.Multiply(num1, num2), Is.EqualTo(expected));
        }
    }
}