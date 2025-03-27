using StrykerApp;

namespace StrykerAppTests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(15, result);
        }
    }
}