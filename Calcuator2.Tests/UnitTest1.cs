using System;
using Xunit;

namespace Calcuator2.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 2, 4)]
        public void Add(int a, int b, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 5)]
        public void CalcuatorSubtract(int number1, int number2, int expected)
        {
            //Arrange
            Calculator calcuator = new Calculator();

            // Act
            int actual = calcuator.Subtract(number1, number2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 3, 9)]
        public void CalcuatorMultiply(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(number1, number2);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(12, 2, 6)]
        public void CalcuatorDivide(int number1, int number2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Divide(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 36)]
        public void CalcuatorTakesExponents(double number1, double number2, double expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double actual = calculator.Exponents(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        public void CalculatorTakesFactorial(int number1, int expected)
        {

            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Factorial(number1);

            // Assert
            Assert.Equal(expected, actual);
        }

        

      
           
       
    }
}
