using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class FindTheDifferenceSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            FindTheDifferenceSolution sut = new FindTheDifferenceSolution();
            string _First = "abcd";
            string _Second = "abcde";
            char _ExpectedChar = 'e';

            char result = sut.FindTheDifference(_First, _Second);

            Assert.Equal(_ExpectedChar, result);
        }

        [Fact]
        public void SecondExample()
        {
            FindTheDifferenceSolution sut = new FindTheDifferenceSolution();
            string _First = "";
            string _Second = "y";
            char _ExpectedChar = 'y';

            char result = sut.FindTheDifference(_First, _Second);

            Assert.Equal(_ExpectedChar, result);
        }

        [Fact]
        public void ThirdExample()
        {
            FindTheDifferenceSolution sut = new FindTheDifferenceSolution();
            string _First = "abcd";
            string _Second = "abdcd";
            char _ExpectedChar = 'd';

            char result = sut.FindTheDifference(_First, _Second);

            Assert.Equal(_ExpectedChar, result);
        }
    }
}
