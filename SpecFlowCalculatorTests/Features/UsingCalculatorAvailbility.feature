Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this
@Availability
Scenario: Calculating MTBF
Given I am a calculator
When I have entered 120 and 130 into the calculator and press MTBF
Then the availability result should be 0.92
@Availability
Scenario: Calculating Availability
Given I am a calculator
When I have entered 210 and 260 into the calculator and press Availability
Then the availability result should be 0.8