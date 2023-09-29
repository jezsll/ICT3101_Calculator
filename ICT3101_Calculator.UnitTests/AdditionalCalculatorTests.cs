using Moq;

namespace ICT3101_Calculator.UnitTests;

public class AdditionalCalculatorTests
{
    private Calculator _calculator;
    private Mock<IFileReader> _mockFileReader;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
        _mockFileReader = new Mock<IFileReader>();
        _mockFileReader.Setup(fr => fr.Read("../../../MagicNumbers.txt")).Returns(new string[3]{"5.00","-1.00","0.00"});
    }

    [Test]
    [TestCase(0, 10.00)]
    [TestCase(2, 0.00)]
    public void TestPositiveInput(double input, double expectedResult)
    {
        double result = _calculator.GenMagicNum(input, _mockFileReader.Object);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(1, 2.00)]
    public void TestNegativeInput(double input, double expectedResult)
    {
        double result = _calculator.GenMagicNum(input, _mockFileReader.Object);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(-1)]
    [TestCase(3)]
    public void TestInvalidInput(double input)
    {
        double result = _calculator.GenMagicNum(input, _mockFileReader.Object);
        Assert.That(result, Is.EqualTo(0));
    }
}
