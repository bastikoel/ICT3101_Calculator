namespace Lab1.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Add_WhenSubtractTwoNumbers_ResultEqualToSum()
        {
            double result = _calculator.Subtract(10, 20);
            Assert.That(result, Is.EqualTo(-10));

        }
        [Test]
        public void Add_WhenMultiplyTwoNumbers_ResultEqualToSum()
        {
            double result = _calculator.Multiply(10, 20);
            Assert.That(result, Is.EqualTo(200));

        }
        [Test]
        public void Add_WhenDivideTwoNumbers_ResultEqualToSum()
        {
            double result = _calculator.Divide(10, 20);
            Assert.That(result, Is.EqualTo(0.5));

        }
        [Test]
        public void Add_WhenDivideByZeroTwoNumbers_ResultEqualToSum()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
        [Test]
        public void Add_WhenFactorialOneNumber_ResultEqualToSum()
        {
            double result = _calculator.Factorial(10);
            Assert.That(result, Is.EqualTo(3628800));

        }
        [Test]
        public void Add_WhenFactorialOneNumberIsLowerThanZero_ResultEqualToSum()
        {
            //double result = _calculator.Factorial(-5);
            Assert.Throws<ArgumentException>(() => _calculator.Factorial(-5));
        }
        [Test]
        public void WhenCalculateAreaOfTriangleWithHeightAndLenght_ResultEqualToSum()
        {
            double result = _calculator.AreaTriangle(10, 5);
            Assert.That(result, Is.EqualTo(25));

        }
        [Test]
        public void WhenCalculateAreaOfTriangleWithTwoNegativeNumbers_ResultEqualToSum()
        {
            Assert.Throws<ArgumentException>(() => _calculator.AreaTriangle(-5, -4));
        }
        [Test]
        public void WhenCalculateAreaOfTriangleWithOneNegativeNumbers_ResultEqualToSum()
        {
            Assert.Throws<ArgumentException>(() => _calculator.AreaTriangle(3, -4));
        }
        [Test]
        public void WhenCalculateAreaOfCircleWithRadius_ResultEqualToSum()
        {
            double result = _calculator.AreaCircle(4);
            Assert.That(result, Is.EqualTo(50.256));
        }
        [Test]
        public void WhenCalculateAreaOfCircleWithNegativeRadius_ResultEqualToSum()
        {
            Assert.Throws<ArgumentException>(() => _calculator.AreaCircle(-4));
        }
        [Test]
        public void WhenCalculateTheNumersOfTheFile()
        {
            // Arrange: Erstelle eine Instanz von FileReader
            IFileReader fileReader = new FileReader();

            // Act: Rufe die GenMagicNum-Methode mit dem fileReader-Parameter auf
            double result = _calculator.GenMagicNum(3, fileReader);

            // Assert
            Assert.That(result, Is.EqualTo(46));
        }

        [Test]
        public void WhenCalculateNegativeNumersOfTheFile()
        {
            // Arrange
            IFileReader fileReader = new FileReader();

            // Act
            double result = _calculator.GenMagicNum(2, fileReader);

            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void WhenCalculateEmptyNumersOfTheFile()
        {
            // Arrange
            IFileReader fileReader = new FileReader();

            // Act
            double result = _calculator.GenMagicNum(8, fileReader);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

    }
}