using CodeWars.Challenges;
using CodeWars.Challenges.CountCharactersInYourStringChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class CountCharactersInYourStringTests
    {
        [Theory]
        [InlineData("", 0)]                // Empty string
        [InlineData("a", 1)]               // Single character
        [InlineData("aba", 2)]             // Repeating characters
        [InlineData("aaabbc", 3)]          // Multiple characters
        [InlineData("abcdefghijklmnopqrstuvwxyz", 26)] // All unique characters
        public void GetCharacterCount_returns_a_dictionary_with_all_characters_and_their_occurances(string input, int expected)
        {
            // Arrange (Given)

            // Act (When)
            var actual = CountCharactersInYourString.Solution(input);

            // Assert (Then)
            Assert.Equal(expected, actual.Count);
        }
    }
}
