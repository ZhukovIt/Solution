using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public sealed class LongestCommonPrefixTests
    {
        [Fact]
        public void FirstExample()
        {
            LongestCommonPrefixSolution sut = new LongestCommonPrefixSolution();
            string[] array = new string[]
            {
                "code",
                "coffee"
            };

            string result = sut.LongestCommonPrefix(array);

            Assert.Equal("co", result);
        }

        [Fact]
        public void SecondExample()
        {
            LongestCommonPrefixSolution sut = new LongestCommonPrefixSolution();
            string[] array = new string[]
            {
                "code",
                "rest"
            };

            string result = sut.LongestCommonPrefix(array);

            Assert.Equal("", result);
        }

        [Fact]
        public void ThirdExample()
        {
            LongestCommonPrefixSolution sut = new LongestCommonPrefixSolution();
            string[] array = new string[]
            {
                "class"
            };

            string result = sut.LongestCommonPrefix(array);

            Assert.Equal("class", result);
        }

        [Fact]
        public void FourthExample()
        {
            LongestCommonPrefixSolution sut = new LongestCommonPrefixSolution();
            string[] array = new string[]
            {
                "home",
                "house",
                "head"
            };

            string result = sut.LongestCommonPrefix(array);

            Assert.Equal("h", result);
        }

        [Fact]
        public void FifthExample()
        {
            LongestCommonPrefixSolution sut = new LongestCommonPrefixSolution();
            string[] array = new string[]
            {
                "aa",
                "aaa"
            };

            string result = sut.LongestCommonPrefix(array);

            Assert.Equal("aa", result);
        }

        [Fact]
        public void EmptyExample()
        {
            LongestCommonPrefixSolution sut = new LongestCommonPrefixSolution();
            string[] array = new string[]
            {

            };

            string result = sut.LongestCommonPrefix(array);

            Assert.Equal("", result);
        }
    }
}
