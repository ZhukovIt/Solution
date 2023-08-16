using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public sealed class CountBitsTests
    {
        [Fact]
        public void FirstExample()
        {
            CountBitsSolution sut = new CountBitsSolution();
            int number = 3;
            int[] _ExpectedResult = new int[]
            {
                0,
                1,
                1,
                2
            };

            int[] result = sut.CountBits(number);

            Assert.Equal(_ExpectedResult, result);
        }

        [Fact]
        public void SecondExample()
        {
            CountBitsSolution sut = new CountBitsSolution();
            int number = 7;
            int[] _ExpectedResult = new int[]
            {
                0,
                1,
                1,
                2,
                1,
                2,
                2,
                3
            };

            int[] result = sut.CountBits(number);

            Assert.Equal(_ExpectedResult, result);
        }

        [Fact]
        public void ThirdExample()
        {
            CountBitsSolution sut = new CountBitsSolution();
            int number = 0;
            int[] _ExpectedResult = new int[]
            {
                0
            };

            int[] result = sut.CountBits(number);

            Assert.Equal(_ExpectedResult, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 1)]
        [InlineData(5, 2)]
        [InlineData(6, 2)]
        [InlineData(7, 3)]
        public void CheckCorrectCalculateCountBitsFromNumber(int _Number, int _ExpectedCountBits)
        {
            CountBitsSolution sut = new CountBitsSolution();

            int result = sut.CalculateCountBitsFromNumber(_Number);

            Assert.Equal(_ExpectedCountBits, result);
        }
    }
}
