namespace ICT3101_Calculator.UnitTests;

public class MagicNumbersTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    [TestCase(0, 10)]
    [TestCase(2, 0)]
    public void TestPositiveInput(double input, double expectedResult)
    {
        double result = _calculator.GenMagicNum(input, new Calculator.FileReader());
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(1, 2)]
    public void TestNegativeInput(double input, double expectedResult)
    {
        double result = _calculator.GenMagicNum(input, new Calculator.FileReader());
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(-1)]
    [TestCase(3)]
    public void TestInvalidInput(double input)
    {
        double result = _calculator.GenMagicNum(input, new Calculator.FileReader());
        Assert.That(result, Is.EqualTo(0));
    }
}
