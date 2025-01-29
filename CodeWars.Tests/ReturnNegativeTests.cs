using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeWars.Challenges.ReturnNegativeChallenge;
using FluentAssertions;

namespace CodeWars.Tests
{
    public class ReturnNegativeTests
    {
        [Theory]
        [InlineData(1, -1)]
        [InlineData(0, 0)]
        [InlineData(-5, -5)]
        public void ReturnNegative_returns_negative_number_when_given_positive_number(int number, int expected)
        {
            // Arrange

            // Act
            int actual = ReturnNegative.Solution(number);

            // Assert
            actual.Should().Be(expected);
        }
    }
}