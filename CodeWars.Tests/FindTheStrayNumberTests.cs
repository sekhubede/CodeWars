using CodeWars.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class FindTheStrayNumberTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 17, 17, 3, 17, 17, 17, 17 }, 3)]
        public void FindTheStrayNumber_ReturnTheStrayNumber(int[] numbers, int expected)
        {
            // Arrange

            // Act
            int actual = Challenge.Stray(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 17, 17, 3, 17, 17, 17, 17 }, 3)]
        public void FindTheStrayNumber_ReturnTheStrayNumberEx(int[] numbers, int expected)
        {
            // Arrange

            // Act
            int actual = Challenge.StrayEx(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
