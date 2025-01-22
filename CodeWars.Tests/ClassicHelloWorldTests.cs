using CodeWars.Challenges;
using CodeWars.Challenges.ClassicHelloWorldChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class ClassicHelloWorldTests
    {
        [Theory]
        [InlineData(new string[] {"Greetings from Javatlacati"}, "Hello World!\r\n")]
        [InlineData(new string[] { "parameter1", "parameter2", "parametern" }, "Hello World!\r\n")]
        public void ClassicHelloWorld_PrintHelloWorld(string[] inputString, string expected)
        {
            // Arrange: Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act: Call the method
            ClassicHelloWorld.Solution(inputString);

            // Assert
            Assert.Equal(expected, output.ToString());
        }
    }
}
