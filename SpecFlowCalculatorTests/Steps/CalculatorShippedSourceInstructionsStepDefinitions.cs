using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorShippedSourceInstructionsStepDefinitions
{
    private Calculator _calculator;
    private double _result;
        
    public CalculatorShippedSourceInstructionsStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I have entered (.*) \(Current Release\), (.*) \(Previous Release\), (.*) \(% code changed\), (.*)\(code deleted\) and  into the calculator and press shipped source instructions")]
    public void WhenIHaveEnteredCurrentReleasePreviousReleaseCodeChangedCodeDeletedAndIntoTheCalculatorAndPressShippedSourceInstructions(double p0, double p1, double p2, double p3)
    {
        _result = _calculator.ShippedSourceInstructions(p0, p1, p2, p3);
    }

    [Then(@"the shipped source instructions result should be (.*) KLOC \(current relase\)")]
    public void ThenTheShippedSourceInstructionsResultShouldBeKlocCurrentRelease(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}