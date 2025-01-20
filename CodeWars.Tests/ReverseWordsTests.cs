using CodeWars.Challenges;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class ReverseWordsTests
    {
        [Theory]
        [InlineData("This is an example!", "sihT si na !elpmaxe")]
        [InlineData("double  spaces", "elbuod  secaps")]
        public void ReverWords_reverses_each_word_in_the_string(string str, string expected)
        {
            // Arrange

            // Act
            string actual = Challenge.ReverseWords(str);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("This is an example!", "sihT si na !elpmaxe")]
        [InlineData("double  spaces", "elbuod  secaps")]
        public void ReverWords_Linq_reverses_each_word_in_the_string(string str, string expected)
        {
            // Arrange

            // Act
            string actual = Challenge.ReverseWords_Linq(str);

            // Assert
            actual.Should().Be(expected);
        }

    }
}
