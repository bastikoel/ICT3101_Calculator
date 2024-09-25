public class CalculatorContext
{
    public Calculator Calculator { get; set; }
    public double Result { get; set; }
    public int Defects { get; set; }
    public int TotalSourceInstructions { get; set; }
    public double FailureRate { get; set; }
    public int FailureCount { get; set; }
    public double OperationalTime { get; set; }
    public double InitialFailureIntensity { get; set; }
    public double ExperiencedFailures { get; set; }
    public string ErrorMessage { get; set; }
}
