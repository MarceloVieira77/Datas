using Xunit;
using Datas;
using System;

namespace Datas.Tests
{
    public class DateCalculatorTests
    {
        [Fact]
        public void AddDays_ShouldAddPositiveDays()
        {
            // Arrange
            var calculator = new DateCalculator();
            var startDate = new DateTime(2023, 1, 1);
            var days = 10;

            // Act
            var result = calculator.AddDays(startDate, days);

            // Assert
            Assert.Equal(new DateTime(2023, 1, 11), result);
        }

        [Fact]
        public void AddDays_ShouldSubtractDays_WhenDaysIsNegative()
        {
            // Arrange
            var calculator = new DateCalculator();
            var startDate = new DateTime(2023, 1, 10);
            var days = -5;

            // Act
            var result = calculator.AddDays(startDate, days);

            // Assert
            Assert.Equal(new DateTime(2023, 1, 5), result);
        }

        [Fact]
        public void AddDays_ShouldReturnSameDate_WhenDaysIsZero()
        {
            // Arrange
            var calculator = new DateCalculator();
            var startDate = new DateTime(2023, 1, 1);
            var days = 0;

            // Act
            var result = calculator.AddDays(startDate, days);

            // Assert
            Assert.Equal(startDate, result);
        }
    }
}
