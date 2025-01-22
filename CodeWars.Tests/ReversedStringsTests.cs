using CodeWars.Challenges;
using CodeWars.Challenges.ReversedStringChallenge;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class ReversedStringsTests
    {
        [Theory]
        [InlineData("world", "dlrow")]
        [InlineData("word", "drow")]
        public void ReversedStrings_reverses_the_string_passed(string str, string expected)
        {
            // Arrange

            // Act
            string actual = ReversedString.Solution(str);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
