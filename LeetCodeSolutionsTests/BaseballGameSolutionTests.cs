using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class BaseballGameSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            BaseballGameSolution sut = new BaseballGameSolution();
            string[] operations = new string[] { "5", "2", "C", "D", "+" };

            int result = sut.CalPoints(operations);

            Assert.Equal(30, result);
        }
        //--------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            BaseballGameSolution sut = new BaseballGameSolution();
            string[] operations = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };

            int result = sut.CalPoints(operations);

            Assert.Equal(27, result);
        }
        //--------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            BaseballGameSolution sut = new BaseballGameSolution();
            string[] operations = new string[] { "1", "C" };

            int result = sut.CalPoints(operations);

            Assert.Equal(0, result);
        }
        //--------------------------------------------------------------------
    }
}
