using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class UsingCalculatorAvailabilityStepDefinitions
{
    private Calculator _calculator;
    private string _result;
        
    // Context Injection for SpecFlow
    public UsingCalculatorAvailabilityStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
    {
        _result = _calculator.CalculateMTBF(p0, p1);
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
    {
        _result = _calculator.CalculateAvailability(p0, p1);
    }
    
    [Then(@"the availability result should be ""(.*)""")]
    public void ThenTheAvailabilityResultShouldBe(string expectedResult)
    {
        Assert.That(_result, Is.EqualTo(expectedResult));
    }
}