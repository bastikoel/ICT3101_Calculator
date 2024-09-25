using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class ReliabilityStepDefinitions
    {
        private readonly CalculatorContext _context;

        public ReliabilityStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }

        [Given(@"I have a reliability calculator")]
        public void GivenIHaveAReliabilityCalculator()
        {
            _context.Calculator = new Calculator();
        }

        [When(@"I calculate the current failure intensity with initial intensity (.*) and (.*) failures experienced over (.*) execution time units")]
        public void WhenICalculateTheCurrentFailureIntensity(double initialIntensity, double failuresExperienced, double executionTimeUnits)
        {
            _context.Result = _context.Calculator.CalculateCurrentFailureIntensity(initialIntensity, failuresExperienced, executionTimeUnits);
        }
        [When(@"I calculate the average number of expected failures with initial failure intensity (.*) and (.*) experienced failures over (.*) execution time units")]
        public void WhenICalculateTheAverageNumberOfExpectedFailures(double initialFailureIntensity, double experiencedFailures, double executionTimeUnits)
        {
            _context.Result = _context.Calculator.CalculateAverageExpectedFailures(initialFailureIntensity, experiencedFailures, executionTimeUnits);
        }
        [Then(@"the failure intensity must be (.*)")]
        public void ThenTheFailureIntensityShouldBe(double expectedIntensity)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedIntensity).Within(0.0001));
        }

        [Then(@"the average expected failures should be (.*)")]
        public void ThenTheAverageExpectedFailuresShouldBe(double expectedFailures)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedFailures).Within(0.0001));
        }
    }
}
