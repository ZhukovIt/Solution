using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class RepeatedSubstringPatternSolutionTests
    {
        [Theory]
        [InlineData("abab")]
        [InlineData("ababab")]
        [InlineData("abcabcabcabc")]
        public void HasRepeatedSubstringPattern(string _Str)
        {
            RepeatedSubstringPatternSolution sut = new RepeatedSubstringPatternSolution();

            bool result = sut.RepeatedSubstringPattern(_Str);

            Assert.True(result);
        }

        [Theory]
        [InlineData("aba")]
        [InlineData("abcabcabcabcd")]
        [InlineData("a")]
        public void HasNotRepeatedSubstringPattern(string _Str)
        {
            RepeatedSubstringPatternSolution sut = new RepeatedSubstringPatternSolution();

            bool result = sut.RepeatedSubstringPattern(_Str);

            Assert.False(result);
        }
    }
}
