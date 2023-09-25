using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorDefectDensityStepDefinitions
{
    private Calculator _calculator;
    private double _result;
        
    public CalculatorDefectDensityStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I have entered (.*) \(Number of Defects\) and (.*) \(Size in KLOC\) into the calculator and press Defect Density")]
    public void WhenIHaveEnteredNumberOfDefectsAndSizeInKlocIntoTheCalculatorAndPressDefectDensity(double p0, double p1)
    {
        _result = _calculator.DefectDensity(p0, p1);
    }

    [Then(@"the defect density result should be (.*) Defects/KLOC")]
    public void ThenTheDefectDensityResultShouldBeDefectsKloc(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}