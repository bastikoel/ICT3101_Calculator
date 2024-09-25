using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly CalculatorContext _context;

        public CalculatorStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _context.Calculator = new Calculator();
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _context.Result = _context.Calculator.Add(p0, p1);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndPressedDivide(double p0, double p1)
        {
            _context.Result = _context.Calculator.Divide(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_context.Result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_context.Result, Is.EqualTo(p0));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(_context.Result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
