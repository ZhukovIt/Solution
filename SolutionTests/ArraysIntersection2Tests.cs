using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public sealed class ArraysIntersection2Tests
    {
        [Fact]
        public void FirstExample()
        {
            ArraysIntersection2Solution sut = new ArraysIntersection2Solution();
            int[] _FirstArray = new int[]
            {
                9, 15, 9, 23, 9
            };
            int[] _SecondArray = new int[]
            {
                16, 9, 23, 9
            };
            int[] _ExpectedArray = new int[]
            {
                9, 23, 9
            };

            int[] result = sut.Intersect(_FirstArray, _SecondArray);

            Assert.Equal(_ExpectedArray, result);
        }

        [Fact]
        public void SecondExample()
        {
            ArraysIntersection2Solution sut = new ArraysIntersection2Solution();
            int[] _FirstArray = new int[]
            {
                2, 4, 5
            };
            int[] _SecondArray = new int[]
            {
                16, 23, 9
            };
            int[] _ExpectedArray = new int[0];

            int[] result = sut.Intersect(_FirstArray, _SecondArray);

            Assert.Equal(_ExpectedArray, result);
        }
    }
}
