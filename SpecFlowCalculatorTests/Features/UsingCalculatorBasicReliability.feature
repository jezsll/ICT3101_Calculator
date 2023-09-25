#User story
#As a software quality enthusiast, I want to calculate the Basic Musa model's failures so that I can meet client requirements. 

Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this
    
    @BasicReliability
    Scenario: Calculating Basic Reliability - Current Failure Intensity
        Given I have a calculator
        When I have entered initial failure intensity - 10, average (expected) number of failures - 50, total number of failures - 100 into the calculator and press current failure intensity
        Then the basic reliability result should be 5
        
    @BasicReliability
    Scenario: Calculating Basic Reliability - Average number of expected failures
        Given I have a calculator
        When I have entered initial failure intensity - 10, total number of failures - 100, CPU hours - 10,  into the calculator and press average number of expected failures
        Then the basic reliability result should be 63.21