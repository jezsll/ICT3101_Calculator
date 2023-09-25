using ICT3101_Calculator;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDivisionStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        
        public UsingCalculatorDivisionStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }

        [When("I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredValuesIntoTheCalculatorAndPressDivide(double num1, double num2)
        {
            try
            {
                _result = _calculator.NewDivide(num1, num2);
            }
            catch (DivideByZeroException)
            {
                _result = double.PositiveInfinity;
            }
        }

        [Then("the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult)); // Adjust precision as needed
        }

        [Then("the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}