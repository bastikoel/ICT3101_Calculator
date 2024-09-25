Feature: UsingDefectDensityCalculation
  As a system quality engineer,
I want to calculate the defect density of a system,
So that I can assess the system's quality and identify areas that need improvement.

  Scenario: Calculate defect density with valid inputs
      Given I own a Taschenrechner
    When I calculate the defect density with 10 defects and 1000 total source instructions
    Then the defect density should be 0.01

  Scenario: Calculate defect density with zero total instructions
  Given I own a Taschenrechner
    When I calculate the defect density with 5 defects and 0 total source instructions
    Then I should receive a defect message "Total source instructions cannot be zero."
