using CodeWars.Challenges;
using CodeWars.Challenges.NumberOfPeopleInTheBusChallenge;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class NumberOfPeopleInTheBusTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Number_ShouldReturnCorrectNumberOfPeopleLeft(List<int[]> peopleListInOut, int expected)
        {
            // Arrange

            // Act
            var actual = NumberOfPeopleInTheBus.Solution(peopleListInOut);

            // Assert
            actual.Should().Be(expected);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new List<int[]> { new int[] { 10, 0 }, new int[] { 3, 5 }, new int[] { 5, 8 } }, 5 };
            yield return new object[] { new List<int[]> { new int[] { 3, 0 }, new int[] { 9, 1 }, new int[] { 4, 10 }, new int[] { 12, 2 }, new int[] { 6, 1 }, new int[] { 7, 10 } }, 17 };
            yield return new object[] { new List<int[]> { new int[] { 3, 0 }, new int[] { 9, 1 }, new int[] { 4, 8 }, new int[] { 12, 2 }, new int[] { 6, 1 }, new int[] { 7, 8 } }, 21 };
        }
    }
}
