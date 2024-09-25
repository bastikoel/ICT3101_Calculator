Feature: ShippedSourceInstructionsCalculation
  As a system quality engineer,
I want to calculate the new total number of Shipped Source Instructions (SSI) for the 2nd release onward,
So that I can track how the codebase evolves across releases and measure the efficiency of improvements.

  Scenario: Calculate SSI with valid parameters
    Given I am a Rechner
    When I calculate the shipped source instructions with a total of 5000 instructions and 200 redundant instructions
    Then the shipped source instructions should be 4800

  
