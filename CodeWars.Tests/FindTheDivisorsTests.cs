using CodeWars.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class FindTheDivisorsTests
    {
        [Theory]
        [InlineData(15, new int[] { 3, 5 })]
        [InlineData(16, new int[] { 2, 4, 8 })]
        [InlineData(253, new int[] { 11, 23 })]
        [InlineData(24, new int[] { 2, 3, 4, 6, 8, 12 })]
        [InlineData(7, null)]
        public void Divisors_ReturnArrayWithDivisorsOfInputNumberInAscendingOrder(int number, int[] expected)
        {
            // Arrange

            // Act
            int[] actual = Challenge.Divisors(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, new int[] { 3, 5 })]
        [InlineData(16, new int[] { 2, 4, 8 })]
        [InlineData(253, new int[] { 11, 23 })]
        [InlineData(24, new int[] { 2, 3, 4, 6, 8, 12 })]
        [InlineData(7, null)]
        public void Divisors_ReturnArrayWithDivisorsOfInputNumberInAscendingOrderEx(int number, int[] expected)
        {
            // Arrange

            // Act
            int[] actual = Challenge.DivisorsEx(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
