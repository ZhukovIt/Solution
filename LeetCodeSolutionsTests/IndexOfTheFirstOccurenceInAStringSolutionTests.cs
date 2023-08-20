using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class IndexOfTheFirstOccurenceInAStringSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            IndexOfTheFirstOccurenceInAStringSolution sut = new IndexOfTheFirstOccurenceInAStringSolution();
            string haystack = "sadbutsad";
            string needle = "sad";

            int result = sut.StrStr(haystack, needle);

            Assert.Equal(0, result);
        }

        [Fact]
        public void SecondExample()
        {
            IndexOfTheFirstOccurenceInAStringSolution sut = new IndexOfTheFirstOccurenceInAStringSolution();
            string haystack = "leetcode";
            string needle = "leeto";

            int result = sut.StrStr(haystack, needle);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void ThirdExample()
        {
            IndexOfTheFirstOccurenceInAStringSolution sut = new IndexOfTheFirstOccurenceInAStringSolution();
            string haystack = "leetcodecode";
            string needle = "code";

            int result = sut.StrStr(haystack, needle);

            Assert.Equal(4, result);
        }
    }
}
