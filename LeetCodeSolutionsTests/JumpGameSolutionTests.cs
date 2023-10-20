using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class JumpGameSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            JumpGameSolution sut = new JumpGameSolution();
            int[] nums = new int[] { 2, 3, 1, 1, 4 };

            bool result = sut.CanJump(nums);
            
            Assert.True(result);
        }
        //--------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            JumpGameSolution sut = new JumpGameSolution();
            int[] nums = new int[] { 3, 2, 1, 0, 4 };

            bool result = sut.CanJump(nums);

            Assert.False(result);
        }
        //--------------------------------------------------------------
    }
}
