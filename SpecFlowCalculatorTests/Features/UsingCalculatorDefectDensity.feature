User story
As a software quality enthusiast, I want to calculate the defect density so that I can meet client requirements. 

Feature: UsingCalculatorDefectDensity
In order to calculate the defect density
As a Software Quality Metric enthusiast
I want to use my calculator to do this

	@DefectDensity
	Scenario: Calculating Defect Density
		Given I have a calculator
		When I have entered 100 (Number of Defects) and 50 (Size in KLOC) into the calculator and press Defect Density
		Then the defect density result should be 2.00 Defects/KLOC
