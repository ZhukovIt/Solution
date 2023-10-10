using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class RomanToIntegerSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            RomanToIntegerSolution sut = new RomanToIntegerSolution();
            string strNumber = "III";

            int result = sut.RomanToInt(strNumber);

            Assert.Equal(3, result);
        }
        //----------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            RomanToIntegerSolution sut = new RomanToIntegerSolution();
            string strNumber = "LVIII";

            int result = sut.RomanToInt(strNumber);

            Assert.Equal(58, result);
        }
        //----------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            RomanToIntegerSolution sut = new RomanToIntegerSolution();
            string strNumber = "MCMXCIV";

            int result = sut.RomanToInt(strNumber);

            Assert.Equal(1994, result);
        }
        //----------------------------------------------------------------
    }
}
