// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using TechTalk.SpecFlow;
//
// namespace SpecFlowCalculatorTests.StepDefinitions;
//
// [Binding]
// public sealed class CalculatorFactorialStepDefinitions
// {
//     // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
//
//     private readonly ScenarioContext _scenarioContext;
//
//     public CalculatorFactorialStepDefinitions(ScenarioContext scenarioContext)
//     {
//         _scenarioContext = scenarioContext;
//     }
//
//     [Given("the first number is (.*)")]
//     public void GivenTheFirstNumberIs(int number)
//     {
//         //TODO: implement arrange (precondition) logic
//         // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
//         // To use the multiline text or the table argument of the scenario,
//         // additional string/Table parameters can be defined on the step definition
//         // method. 
//
//         _scenarioContext.Pending();
//     }
//
//     [Given("the second number is (.*)")]
//     public void GivenTheSecondNumberIs(int number)
//     {
//         //TODO: implement arrange (precondition) logic
//         // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
//         // To use the multiline text or the table argument of the scenario,
//         // additional string/Table parameters can be defined on the step definition
//         // method. 
//
//         _scenarioContext.Pending();
//     }
//
//     [When("the two numbers are added")]
//     public void WhenTheTwoNumbersAreAdded()
//     {
//         //TODO: implement act (action) logic
//
//         _scenarioContext.Pending();
//     }
//
//     [Then("the result should be (.*)")]
//     public void ThenTheResultShouldBe(int result)
//     {
//         //TODO: implement assert (verification) logic
//
//         _scenarioContext.Pending();
//     }
// }

using ICT3101_Calculator;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        
        public UsingCalculatorFactorialStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }

        [When("I enter (.*) into the calculator and press calculate factorial")]
        public void WhenIEnterIntoTheCalculatorAndPressCalculateFactorial(int n)
        {
            _result = _calculator.CalculateFactorial(n);
        }

        [Then("the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(int expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }
    }
}