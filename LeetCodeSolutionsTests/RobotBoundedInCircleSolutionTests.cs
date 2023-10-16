using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class RobotBoundedInCircleSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            RobotBoundedInCircleSolution sut = new RobotBoundedInCircleSolution();
            string instructions = "GGLLGG";

            bool result = sut.IsRobotBounded(instructions);

            Assert.True(result);
        }
        //-------------------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            RobotBoundedInCircleSolution sut = new RobotBoundedInCircleSolution();
            string instructions = "GG";

            bool result = sut.IsRobotBounded(instructions);

            Assert.False(result);
        }
        //-------------------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            RobotBoundedInCircleSolution sut = new RobotBoundedInCircleSolution();
            string instructions = "GL";

            bool result = sut.IsRobotBounded(instructions);

            Assert.True(result);
        }
        //-------------------------------------------------------------------------------
    }
}
