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
    }
}
