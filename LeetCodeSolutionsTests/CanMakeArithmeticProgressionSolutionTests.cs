using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class CanMakeArithmeticProgressionSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            CanMakeArithmeticProgressionSolution sut = new CanMakeArithmeticProgressionSolution();
            int[] _Array = new int[]
            {
                3, 5, 1
            };

            bool result = sut.CanMakeArithmeticProgression(_Array);

            Assert.True(result);
        }

        [Fact]
        public void SecondExample()
        {
            CanMakeArithmeticProgressionSolution sut = new CanMakeArithmeticProgressionSolution();
            int[] _Array = new int[]
            {
                1, 2, 4
            };

            bool result = sut.CanMakeArithmeticProgression(_Array);

            Assert.False(result);
        }
    }
}
