using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public sealed class ValidParenthesesTests
    {
        [Theory]
        [InlineData("({})")]
        [InlineData("({[[]]})")]
        [InlineData("")]
        public void Parentheses_Valid_Is_Success(string _Parentheses)
        {
            ValidParenthesesSolution sut = new ValidParenthesesSolution();

            bool result = sut.IsValidParentheses(_Parentheses);

            Assert.True(result);
        }

        [Theory]
        [InlineData("[)")]
        [InlineData("(([{{}]}))")]
        [InlineData(")")]
        [InlineData("()]")]
        public void Parentheses_Valid_Is_Failure(string _Parentheses)
        {
            ValidParenthesesSolution sut = new ValidParenthesesSolution();

            bool result = sut.IsValidParentheses(_Parentheses);

            Assert.False(result);
        }
    }
}
