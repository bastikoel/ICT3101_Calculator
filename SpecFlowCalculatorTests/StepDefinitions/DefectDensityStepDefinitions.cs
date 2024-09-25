using NUnit.Framework;

[Binding]
public class DefectDensityStepDefinitions
{
    private readonly CalculatorContext _context;

    public DefectDensityStepDefinitions(CalculatorContext context)
    {
        _context = context;
    }

    [Given(@"I own a Taschenrechner")]
    public void GivenIHaveACalculator()
    {
        _context.Calculator = new Calculator();
    }

    // Step definition for calculating defect density with given defects and source instructions
    [When(@"I calculate the defect density with (.*) defects and (.*) total source instructions")]
    public void WhenICalculateTheDefectDensity(int defects, int totalSourceInstructions)
    {
        try
        {
            _context.Result = _context.Calculator.CalculateDefectDensity(defects, totalSourceInstructions);
        }
        catch (ArgumentException ex)
        {
            _context.ErrorMessage = ex.Message;
        }
    }

    // Step definition to validate the defect density result
    [Then(@"the defect density should be (.*)")]
    public void ThenTheDefectDensityShouldBe(double expectedDefectDensity)
    {
        Assert.That(_context.Result, Is.EqualTo(expectedDefectDensity));
    }

    // Step definition to validate the error message when total source instructions is zero
    [Then(@"I should receive a defect message ""(.*)""")]
    public void ThenIShouldReceiveADefectMessage(string expectedErrorMessage)
    {
        Assert.That(_context.ErrorMessage, Is.EqualTo(expectedErrorMessage));
    }
}
