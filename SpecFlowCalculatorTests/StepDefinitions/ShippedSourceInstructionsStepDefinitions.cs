using NUnit.Framework;

[Binding]
public class ShippedSourceInstructionsStepDefinitions
{
    private readonly CalculatorContext _context;

    public ShippedSourceInstructionsStepDefinitions(CalculatorContext context)
    {
        _context = context;
    }
    [Given(@"I am a Rechner")]
    public void GivenIHaveACalculator()
    {
        _context.Calculator = new Calculator();
    }

    [When(@"I calculate the shipped source instructions with a total of (.*) instructions and (.*) redundant instructions")]
    public void WhenICalculateTheShippedSourceInstructions(int totalInstructions, int redundantInstructions)
    {
        
            _context.Result = _context.Calculator.CalculateSSI(totalInstructions, redundantInstructions);
        
        
    }

    [Then(@"the shipped source instructions should be (.*)")]
    public void ThenTheShippedSourceInstructionsShouldBe(double expectedSSI)
    {
        Assert.That(_context.Result, Is.EqualTo(expectedSSI));
    }

    [Then(@"I should receive an error message ""(.*)""")]
    public void ThenIShouldReceiveAnErrorMessage(string expectedErrorMessage)
    {
        Assert.That(_context.ErrorMessage, Is.EqualTo(expectedErrorMessage));
    }
}
