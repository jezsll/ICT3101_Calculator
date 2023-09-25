Feature: UsingCalculatorFactorial
In order to calculate factorials
As a math enthusiast
I want to understand how the factorial function works

	@Factorial
	Scenario: Calculating factorial of a positive number
		Given I have a calculator
		When I enter 5 into the calculator and press calculate factorial
		Then the factorial result should be 120

	@Factorial
	Scenario: Calculating factorial of zero
		Given I have a calculator
		When I enter 0 into the calculator and press calculate factorial
		Then the factorial result should be 1