using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class ValidAnagramSolutionTests
    {
        [Fact]
        public void IsAnagram()
        {
            ValidAnagramSolution sut = new ValidAnagramSolution();
            string s = "anagram";
            string t = "nagaram";

            bool result = sut.IsAnagram(s, t);

            Assert.True(result);
        }

        [Fact]
        public void IsNotAnagram()
        {
            ValidAnagramSolution sut = new ValidAnagramSolution();
            string s = "rat";
            string t = "car";

            bool result = sut.IsAnagram(s, t);

            Assert.False(result);
        }
    }
}
