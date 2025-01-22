using CodeWars.Challenges.BreakCamelCaseChallenge;

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
            string actual = BreakCamelCase.Solution(inputString);

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
            string actual = BreakCamelCase.Solution2(inputString);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
