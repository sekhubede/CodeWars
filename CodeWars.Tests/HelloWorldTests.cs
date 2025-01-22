using CodeWars.Challenges;
using CodeWars.Challenges.HelloWorldChallenge;

namespace CodeWars.Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void Greet_ReturnHelloWorld()
        {
            // Arrange
            const string expected = "hello world!";
            // Act
            var actual = HelloWorld.Solution();

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}