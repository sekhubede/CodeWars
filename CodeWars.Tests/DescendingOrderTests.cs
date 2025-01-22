using CodeWars.Challenges;
using CodeWars.Challenges.DescendingOrderChallenge;

namespace CodeWars.Tests
{
    public class DescendingOrderTests
    {

        [Theory]
        [InlineData(42145, 54421)]
        [InlineData(145263, 654321)]
        [InlineData(123456789, 987654321)]
        public void DescendingOrder_ReturnDigitsInDescendingOrder(int number, int expected)
        {
            // Arrange

            // Act
            int actual = DescendingOrder.Solution(number);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
