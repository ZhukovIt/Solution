using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class LengthOfLastWordSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            LengthOfLastWordSolution sut = new LengthOfLastWordSolution();
            string input = "Hello World";

            int result = sut.LengthOfLastWord(input);

            Assert.Equal(5, result);
        }
        //---------------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            LengthOfLastWordSolution sut = new LengthOfLastWordSolution();
            string input = "   fly me   to   the moon  ";

            int result = sut.LengthOfLastWord(input);

            Assert.Equal(4, result);
        }
        //---------------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            LengthOfLastWordSolution sut = new LengthOfLastWordSolution();
            string input = "luffy is still joyboy";

            int result = sut.LengthOfLastWord(input);

            Assert.Equal(6, result);
        }
        //---------------------------------------------------------------------------
    }
}
