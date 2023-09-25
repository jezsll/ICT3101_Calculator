#User story
#As a software quality enthusiast, I want to calculate the Logarithmic Musa model's failures so that I can meet client requirements.

Feature: UsingCalculatorLogarithmicModel
In order to calculate the Logarithmic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this
    
	@BasicReliability
	Scenario: Calculating Logarithmic Model Reliability - Current Failure Intensity
		Given I have a calculator
		When I have entered 10 (initial failure intensity), 0.02 (failure intensity decay parameter) and 50 (expected number of failures at a given time) into the calculator and press current failure intensity
		Then the logarithmic model reliability result should be 3.68 failures/hour
        
	@BasicReliability
	Scenario: Calculating Logarithmic Model Reliability - Average number of expected failures
		Given I have a calculator
		When I have entered 10 (initial failure intensity), 0.02 (failure intensity decay parameter) and 10 (CPU hours)  into the calculator and press average number of expected failures
		Then the logarithmic model reliability result should be 54.93 failures