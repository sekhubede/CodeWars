using CodeWars.Challenges;
using CodeWars.Challenges.IsNumberPrimeChallenge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class IsNumberPrimeTests
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        public void IsNumberPrime_ReturnTrueIfNumberPrimeOtherwiseFalse(int number, bool expected)
        {
            // Arrange


            // Act
            bool actual = IsNumberPrime.Solution(number);


            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
