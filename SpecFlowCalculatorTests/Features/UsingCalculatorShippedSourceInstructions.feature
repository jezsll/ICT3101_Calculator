#User story
#As a software quality enthusiast, I want to calculate the Shipped Source Instructions(SSI) so that I can meet client requirements. 

Feature: UsingCalculatorShippedSourceInstructions
In order to calculate the Shipped Source Instructions(SSI)
As a Software Quality Metric enthusiast
I want to use my calculator to do this

	@ShippedSourceInstructions
	Scenario: Calculating Shipped Source Instructions
		Given I have a calculator
		When I have entered 50 (Current Release), 40 (Previous Release), 25 (% code changed), 10(code deleted) and  into the calculator and press shipped source instructions
		Then the shipped source instructions result should be 70.00 KLOC (current release)
		
	