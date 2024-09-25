Feature: Factorial Calculations
  In order to verify the calculator's ability to calculate factorials
  As a user
  I want to calculate the factorial of different numbers, including edge cases

  @Factorial
  Scenario: Calculating the factorial of a positive integer
    Given I own a calculator
    When I calculate the factorial of 5
    Then the fractional should be exactly 120

  @FactorialZero
  Scenario: Calculating the factorial of zero
    Given I own a calculator
    When I calculate the factorial of 0
    Then the fractional should be exactly 1

  @FactorialEdgeCases
  Scenario Outline: Calculating factorial with different edge cases
    Given I own a calculator
    When I calculate the factorial of <number>
    Then the fractional should be exactly <fractional>

    Examples:
      | number | fractional   |
      | 1      | 1        |
      | 3      | 6        |
      | 7      | 5040     |
      | 10     | 3628800  |
