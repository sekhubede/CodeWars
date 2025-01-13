using CodeWars.Challenges;

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
            var actual = Challenge.Greet();

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}