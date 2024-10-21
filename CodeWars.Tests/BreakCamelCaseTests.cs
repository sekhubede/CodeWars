using CodeWars.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class BreakCamelCaseTests
    {
        [Theory]
        [InlineData("camelCasing", "camel Casing")]
        [InlineData("camelCasingTest", "camel Casing Test")]
        [InlineData("indentifier", "indentifier")]
        [InlineData("", "")]
        public void BreakCamelCase_ReturnCamelCasingUsingSpaceBetweenWords(string inputString, string expected)
        {
            // Arrange

            // Act
            string actual = Challenge.BreakCamelCase(inputString);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("camelCasing", "camel Casing")]
        [InlineData("camelCasingTest", "camel Casing Test")]
        [InlineData("indentifier", "indentifier")]
        [InlineData("", "")]
        public void BreakCamelCaseLinq_ReturnCamelCasingUsingSpaceBetweenWords(string inputString, string expected)
        {
            // Arrange

            // Act
            string actual = Challenge.BreakCamelCaseLinq(inputString);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
