using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorLogarithmicModelStepDefinitions
{
    private Calculator _calculator;
    private double _result;
        
    public CalculatorLogarithmicModelStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I have entered (.*) \(initial failure intensity\), (.*) \(failure intensity decay parameter\) and (.*) \(expected number of failures at a given time\) into the calculator and press current failure intensity")]
    public void WhenIHaveEnteredInitialFailureIntensityFailureIntensityDecayParameterAndExpectedNumberOfFailuresAtAGivenTimeIntoTheCalculatorAndPressCurrentFailureIntensity(double p0, double p1, double p2)
    {
        _result = _calculator.LogarithmicCurrentFailureIntensity(p0, p1, p2);
    }

    [Then(@"the logarithmic model reliability result should be (.*) failures/hour")]
    public void ThenTheLogarithmicModelReliabilityResultShouldBeFailuresHour(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*) \(initial failure intensity\), (.*) \(failure intensity decay parameter\) and (.*) \(CPU hours\)  into the calculator and press average number of expected failures")]
    public void WhenIHaveEnteredInitialFailureIntensityFailureIntensityDecayParameterAndCpuHoursIntoTheCalculatorAndPressAverageNumberOfExpectedFailures(double p0, double p1, double p2)
    {
        _result = _calculator.LogarithmicAverageNumberOfExpectedFailures(p0, p1, p2);
    }

    [Then(@"the logarithmic model reliability result should be (.*) failures")]
    public void ThenTheLogarithmicModelReliabilityResultShouldBeFailures(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}