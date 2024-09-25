Feature: Calculator operations
  In order to conquer divisions
  As a division enthusiast
  I want to understand a variety of division operations

  @Divisions
  Scenario Outline: Dividing two numbers
    Given I have a calculator
    When I have entered <number1> and <number2> into the calculator and press divide
    Then the division result should be <result>

    Examples:
      | number1 | number2 | result             |
      | 1       | 2       | 0.5               |
      | 0       | 15      | 0                 |
      | 15      | 0       | positive_infinity  |
      | 0       | 0       | 1          |
    
    @Add
    Scenario Outline: Add zeros for special cases
        Given I have a calculator
        When I have entered <number1> and <number2> into the calculator and press add
        Then the result should be <result>
        Examples:
        |value1 |value2 |value3 |
        |1		|11		|7		|
        |10		|11		|11		|
        |11		|11		|15		|
