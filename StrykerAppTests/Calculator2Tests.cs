using StrykerApp;
using System;
using Xunit;

namespace StrykerAppTests;
public class Calculator2Tests
{
    private readonly Calculator2 _calculator;

    public Calculator2Tests()
    {
        _calculator = new Calculator2();
    }

    [Fact]
    public void Divide_WithValidNumbers_ReturnsCorrectResult()
    {
        // Arrange
        double num1 = 10;
        double num2 = 2;

        // Act
        double result = _calculator.Divide(num1, num2);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsArgumentException()
    {
        // Arrange
        double num1 = 10;
        double num2 = 0;

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => _calculator.Divide(num1, num2));
        Assert.Equal("Cannot divide by zero.", exception.Message);
    }

    [Fact]
    public void Divide_NegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        double num1 = -10;
        double num2 = 2;

        // Act
        double result = _calculator.Divide(num1, num2);

        // Assert
        Assert.Equal(-5, result);
    }

    [Fact]
    public void Divide_ZeroNumerator_ReturnsZero()
    {
        // Arrange
        double num1 = 0;
        double num2 = 5;

        // Act
        double result = _calculator.Divide(num1, num2);

        // Assert
        Assert.Equal(0, result);
    }
}
