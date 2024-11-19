using CodeWars.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class IpValidationTests
    {
        [Theory]
        [InlineData("0.0.0.0", true)]
        [InlineData("12.255.56.1", true)]
        [InlineData("137.255.156.100", true)]
        [InlineData("", false)]
        [InlineData("abc.def.ghi.jkl", false)]
        [InlineData("12.34.56", false)]
        [InlineData("12.34.56.78sf", false)]
        [InlineData("123.045.067.089", false)]
        [InlineData("12.34.56 .1", false)]
        public void IsValidIp_ReturnsTrueIfValidIPv4AddressInDotDecimalFormat(string ipAddress, bool expected)
        {
            // Arrange

            // Act
            bool actual = Challenge.IsValidIp(ipAddress);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
