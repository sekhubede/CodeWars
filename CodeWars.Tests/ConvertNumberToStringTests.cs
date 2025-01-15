using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeWars.Challenges;
using FluentAssertions;

namespace CodeWars.Tests
{
    public class ConvertNumberToStringTests
    {
        [Theory]
        [InlineData(123, "123")]
        [InlineData(999, "999")]
        [InlineData(-100, "-100")]
        public void NumberToString_ReturnNumberTransformedIntoString(int num, string expected)
        {
            // Arrange

            // Act
            string actual = Challenge.NumberToString(num);

            // Assert
            actual.Should().Be(expected);
        }
    }
}