using ICT3101_Calculator;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(int p0, int p1)
        {
            _result = _calculator.BinaryAddition(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}