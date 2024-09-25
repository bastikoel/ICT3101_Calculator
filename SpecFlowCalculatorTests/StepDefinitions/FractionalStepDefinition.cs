//Context Injection for SpecFLow:
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class FractionalStepDefinitions
    {
        private readonly CalculatorContext _context;
        public FractionalStepDefinitions(CalculatorContext calculator)
        {
            this._context = calculator;
        }
        [Given(@"I own a calculator")]
        public void GivenIHaveACalculator()
        {
            _context.Calculator = new Calculator();
        }

        [When(@"I calculate the factorial of (.*)")]
        public void WhenICalculateTheFactorialOf(double number)
        {
            
                _context.Result = _context.Calculator.Factorial(number);
            
            
        }

        [Then(@"the fractional should be exactly (.*)")]
        public void ThenTheFractionalShouldBeExactly(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }
    }
}
//--------------------------------