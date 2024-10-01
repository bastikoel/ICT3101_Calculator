using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;
        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }
        [Test]
        public void WhenCalculateTheNumersOfTheFile()
        {
            // Act: Verwende _mockFileReader.Object anstelle von FileReader
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object); // 42 + 42 = 84; 84 * 1 = 84

            // Assert
            Assert.That(result, Is.EqualTo(84));
        }

        [Test]
        public void WhenCalculateNegativeNumersOfTheFile()
        {
            // Setup: Beispiel für negative Zahlen
            _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt"))
                           .Returns(new string[] { "-10", "-5" }); // -15 total

            // Act
            double result = _calculator.GenMagicNum(2, _mockFileReader.Object); // -15 * 2 = -30

            // Assert
            Assert.That(result, Is.EqualTo(-30));
        }

        [Test]
        public void WhenCalculateEmptyNumersOfTheFile()
        {
            // Setup: Beispiel für eine leere Datei
            _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt"))
                           .Returns(new string[0]); // Leeres Array

            // Act
            double result = _calculator.GenMagicNum(8, _mockFileReader.Object); // 0 * 8 = 0

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
