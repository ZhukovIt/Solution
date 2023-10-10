using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class MonotonicArraySolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            MonotonicArraySolution sut = new MonotonicArraySolution();
            int[] nums = new int[] { 1, 2, 2, 3 };

            bool result = sut.IsMonotonic(nums);

            Assert.True(result);
        }
        //-----------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            MonotonicArraySolution sut = new MonotonicArraySolution();
            int[] nums = new int[] { 6, 5, 4, 4 };

            bool result = sut.IsMonotonic(nums);

            Assert.True(result);
        }
        //-----------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            MonotonicArraySolution sut = new MonotonicArraySolution();
            int[] nums = new int[] { 1, 3, 2 };

            bool result = sut.IsMonotonic(nums);

            Assert.False(result);
        }
        //-----------------------------------------------------------
        [Fact]
        public void FourthExample()
        {
            MonotonicArraySolution sut = new MonotonicArraySolution();
            int[] nums = new int[] { 1, 1, 2 };

            bool result = sut.IsMonotonic(nums);

            Assert.True(result);
        }
        //-----------------------------------------------------------
    }
}
