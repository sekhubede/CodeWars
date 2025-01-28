using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeWars.Challenges.IsogramsChallenge;
using FluentAssertions;

namespace CodeWars.Tests
{
    public class IsogramTests
    {
        [Theory]
        [InlineData("Dermatoglyphics", true)]
        [InlineData("isogram", true)]
        [InlineData("moose", false)]
        [InlineData("isIsogram", false)]
        [InlineData("aba", false)]
        [InlineData("moOse", false)]
        [InlineData("thumbscrewjapingly", true)]
        [InlineData("", true)]
        public void Isogram_returns_true_if_isogram_otherwise_false(string str, bool expected)
        {
            // Arrange

            // Act
            bool actual = Isogram.Solution(str);

            // Assert
            actual.Should().Be(expected);
        }
    }
}