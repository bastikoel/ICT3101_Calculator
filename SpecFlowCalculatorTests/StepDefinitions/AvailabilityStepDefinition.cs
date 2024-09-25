using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class AvailabilityStepDefinitions
    {
        private readonly CalculatorContext _context;
        public AvailabilityStepDefinitions(CalculatorContext calculator)
        {
            this._context = calculator;
        }
        [Given(@"I am a calculator")]
        public void GivenIHaveACalculator()
        {
            _context.Calculator = new Calculator();
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenICalculateTheMTBFOf(double number1, double number2)
        {

            _context.Result = _context.Calculator.Divide(number1, number2);


        }
        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenICalculateTheAvailabilityOf(double number1, double number2)
        {

            _context.Result = _context.Calculator.Divide(number1, number2);


        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheFractionalShouldBeExactly(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult).Within(0.1));
        }
    }
}