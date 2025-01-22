using CodeWars.Challenges;
using CodeWars.Challenges.RegexValidatePinCodeChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class RegexValidatePinCodeTests
    {
        [Theory]
        [InlineData("00000000", false)]
        [InlineData("-1.234", false)]
        [InlineData("1.234", false)]
        [InlineData("1234567", false)]
        [InlineData("12345", false)]
        [InlineData("090909", true)]
        [InlineData("000000", true)]
        [InlineData("098765", true)]
        [InlineData("123456", true)]
        [InlineData("1111", true)]
        [InlineData("0000", true)]
        [InlineData("1234", true)]
        [InlineData("1234 ", false)]
        public void ValidatePin_ReturnsTrueIfExactlyFourOrFiveDigits(string pin, bool expected)
        {
            // Arrange

            // Act
            bool actual = RegexValidatePinCode.Solution(pin);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
