using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public class ValidPalindromeTests
    {
        [Fact]
        public void FirstExample()
        {
            ValidPalindromeSolution sut = new ValidPalindromeSolution();
            string _Value = "aga";

            bool result = sut.IsValidPalindrome(_Value);

            Assert.True(result);
        }

        [Fact]
        public void SecondExample()
        {
            ValidPalindromeSolution sut = new ValidPalindromeSolution();
            string _Value = "agta";

            bool result = sut.IsValidPalindrome(_Value);

            Assert.True(result);
        }

        [Fact]
        public void ThirdExample()
        {
            ValidPalindromeSolution sut = new ValidPalindromeSolution();
            string _Value = "abcdeffedcba";

            bool result = sut.IsValidPalindrome(_Value);

            Assert.True(result);
        }

        [Fact]
        public void EmptyExample()
        {
            ValidPalindromeSolution sut = new ValidPalindromeSolution();
            string _Value = "";

            bool result = sut.IsValidPalindrome(_Value);

            Assert.False(result);
        }
    }
}
