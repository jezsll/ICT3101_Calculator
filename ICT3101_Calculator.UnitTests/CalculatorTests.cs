using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);

            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(30, 10);

            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            // Act
            double result = _calculator.Multiply(5, 4);

            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
        {
            // Act
            double result = _calculator.Divide(20, 5);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.DivideByZero(0, 0), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _calculator.DivideByZero(a, b));
        }

        [Test]
        [TestCase(0, 1)] // 0! = 1
        [TestCase(1, 1)] // 1! = 1
        [TestCase(5, 120)] // 5! = 120
        [TestCase(10, 3628800)] // 10! = 3,628,800
        public void CalculateFactorial_ValidInput_ReturnsCorrectResult(int n, long expected)
        {
            long result = _calculator.CalculateFactorial(n);
            //Assert.AreEqual(expected, result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        public void CalculateFactorial_NegativeInput_ThrowsArgumentException(int n)
        {
            Assert.Throws<ArgumentException>(() => _calculator.CalculateFactorial(n));
        }

        [Test]
        [TestCase(5, 6, 15)] // Height = 5, Base Length = 6, Expected Area = 15
        [TestCase(10, 8, 40)] // Height = 10, Base Length = 8, Expected Area = 40
        [TestCase(3, 7, 10.5)] // Height = 3, Base Length = 7, Expected Area = 10.5
        public void CalculateTriangleArea_ValidInputs_ReturnsCorrectResult(double height, double baseLength, double expectedArea)
        {
            double result = _calculator.CalculateTriangleArea(height, baseLength);
            Assert.AreEqual(expectedArea, result, 0.001);
        }

        [Test]
        [TestCase(5, 78.54)] // Radius = 5, Expected Area = π * 5^2 ≈ 78.54
        [TestCase(10, 314.16)] // Radius = 10, Expected Area = π * 10^2 ≈ 314.16
        [TestCase(3.5, 38.484)] // Radius = 3.5, Expected Area = π * 3.5^2 ≈ 38.484
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectResult(double radius, double expectedArea)
        {
            double result = _calculator.CalculateCircleArea(radius);
            Assert.AreEqual(expectedArea, result, 0.001);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);

            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);

            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);

            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
    }
}
