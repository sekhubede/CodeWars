using CodeWars.Challenges;
using CodeWars.Challenges.ComplementaryDNAChallenge;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    public class ComplementaryDNATests
    {
        [Theory]
        [InlineData("AAAA", "TTTT")]
        [InlineData("ATTGC", "TAACG")]
        [InlineData("GTAT", "CATA")]
        [InlineData("AAGG", "TTCC")]
        [InlineData("CGCG", "GCGC")]
        [InlineData("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
        public void MakeComplement_return_the_other_complementary_DNA_strand(string dna, string expected)
        {
            // Arrange

            // Act
            var actual = ComplementaryDNA.Solution(dna);

            // Assert
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("AAAA", "TTTT")]
        [InlineData("ATTGC", "TAACG")]
        [InlineData("GTAT", "CATA")]
        [InlineData("AAGG", "TTCC")]
        [InlineData("CGCG", "GCGC")]
        [InlineData("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
        public void MakeComplement_Linq_return_the_other_complementary_DNA_strand(string dna, string expected)
        {
            // Arrange

            // Act
            var actual = ComplementaryDNA.Solution2(dna);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
