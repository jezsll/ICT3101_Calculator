using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorBasicReliabilityStepDefinitions
{
    
    private Calculator _calculator;
    private double _result;
        
    // Context Injection for SpecFlow
    public CalculatorBasicReliabilityStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I have entered initial failure intensity (.*), average \(expected\) number of failures - (.*), total number of failures - (.*) into the calculator and press current failure intensity")]
    public void WhenIHaveEnteredInitialFailureIntensityAverageExpectedNumberOfFailuresTotalNumberOfFailuresIntoTheCalculatorAndPressCurrentFailureIntensity(double p0, double p1, double p2)
    {
        _result = _calculator.CurrentFailureIntensity(p0, p1, p2);
    }
    
    [When(@"I have entered initial failure intensity - (.*), total number of failures - (.*), CPU hours - (.*),  into the calculator and press average number of expected failures")]
    public void WhenIHaveEnteredInitialFailureIntensityTotalNumberOfFailuresCpuHoursIntoTheCalculatorAndPressAverageNumberOfExpectedFailures(int p0, int p1, int p2)
    {
        _result = _calculator.AverageNumberOfExpectedFailures(p0, p1, p2);
    }

    [Then(@"the basic reliability result should be (.*)")]
    public void ThenTheBasicReliabilityResultShouldBe(double expectedResult)
    {
        Assert.That(_result, Is.EqualTo(expectedResult));
    }
}