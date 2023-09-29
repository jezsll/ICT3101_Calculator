namespace ICT3101_Calculator.UnitTests;

public class MagicNumbersTests
{
    private Calculator _calculator; 
    private IFileReader _fileReader;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
        _fileReader = new FileReader();
    }

    [Test]
    [TestCase(0, 10.00)]
    [TestCase(2, 0.00)]
    public void TestPositiveInput(double input, double expectedResult)
    {
        double result = _calculator.GenMagicNum(input, _fileReader);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(1, 2.00)]
    public void TestNegativeInput(double input, double expectedResult)
    {
        double result = _calculator.GenMagicNum(input, _fileReader);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(-1)]
    [TestCase(3)]
    public void TestInvalidInput(double input)
    {
        double result = _calculator.GenMagicNum(input, _fileReader);
        Assert.That(result, Is.EqualTo(0));
    }
}
