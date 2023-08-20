using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class MergeAlternatelySolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            MergeAlternatelySolution sut = new MergeAlternatelySolution();
            string _Word1 = "abc";
            string _Word2 = "pqr";
            string _ExpectedWord = "apbqcr";

            string result = sut.MergeAlternately(_Word1, _Word2);

            Assert.Equal(_ExpectedWord, result);
        }

        [Fact]
        public void SecondExample()
        {
            MergeAlternatelySolution sut = new MergeAlternatelySolution();
            string _Word1 = "ab";
            string _Word2 = "pqrs";
            string _ExpectedWord = "apbqrs";

            string result = sut.MergeAlternately(_Word1, _Word2);

            Assert.Equal(_ExpectedWord, result);
        }

        [Fact]
        public void ThirdExample()
        {
            MergeAlternatelySolution sut = new MergeAlternatelySolution();
            string _Word1 = "abcd";
            string _Word2 = "pq";
            string _ExpectedWord = "apbqcd";

            string result = sut.MergeAlternately(_Word1, _Word2);

            Assert.Equal(_ExpectedWord, result);
        }
    }
}
