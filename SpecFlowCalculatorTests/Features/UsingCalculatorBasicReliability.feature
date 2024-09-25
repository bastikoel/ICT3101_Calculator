Feature: UsingCalculatorBasicReliability
As a system quality engineer,
I want to calculate the failure intensity using the Musa Logarithmic model,
So that I can predict system stability and the likelihood of future failures.

As a system quality engineer,
I want to calculate the number of expected failures based on the Musa Logarithmic model,
So that I can anticipate the number of potential failures over a given period.
@LambdaCalculation
  Scenario: Calculate the current failure intensity
    Given I have a reliability calculator
    When I calculate the current failure intensity with initial intensity 10 and 20 failures experienced over 50 execution time units
    Then the failure intensity must be 6

  @LambdaCalculation
  Scenario: Calculate the current failure intensity with zero failures
    Given I have a reliability calculator
    When I calculate the current failure intensity with initial intensity 10 and 0 failures experienced over 50 execution time units
    Then the failure intensity must be 10

    @MuCalculation
  Scenario: Calculate the average number of expected failures
    Given I have a reliability calculator
    When I calculate the average number of expected failures with initial failure intensity 10 and 2 experienced failures over 50 execution time units
    Then the average expected failures should be 10

  @MuCalculation
  Scenario: Calculate the average number of expected failures with zero failures
    Given I have a reliability calculator
    When I calculate the average number of expected failures with initial failure intensity 10 and 0 experienced failures over 50 execution time units
    Then the average expected failures should be 0