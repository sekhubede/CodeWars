using CodeWars.Challenges;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class CreatePhoneNumberTests
    {
        [Theory]
        [InlineData(new int[] {1,2,3,4,5,6,7,8,9,0}, "(123) 456-7890")]
        [InlineData(new int[] {1,1,1,1,1,1,1,1,1,1}, "(111) 111-1111")]
        public void CreatePhoneNumber_ReturnStringOfNumbersInPhoneNumberFormat(int[] numbers, string expected)
        {
            // Arrange 

            // Act
            string actual = Challenge.CreatePhoneNumber(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(111) 111-1111")]
        public void CreatePhoneNumberLinq_ReturnStringOfNumbersInPhoneNumberFormat(int[] numbers, string expected)
        {
            // Arrange 

            // Act
            string actual = Challenge.CreatePhoneNumberLinq(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(111) 111-1111")]
        public void CreatePhoneNumberEx_ReturnStringOfNumbersInPhoneNumberFormat(int[] numbers, string expected)
        {
            // Arrange 

            // Act
            string actual = Challenge.CreatePhoneNumber(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
