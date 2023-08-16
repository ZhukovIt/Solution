using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public sealed class FirstUniqueCharacterTests
    {
        [Fact]
        public void FirstExample()
        {
            FirstUniqueCharacterSolution sut = new FirstUniqueCharacterSolution();
            string _Value = "code";

            int result = sut.FirstUniqueChar(_Value);

            Assert.Equal(0, result);
        }

        [Fact]
        public void SecondExample()
        {
            FirstUniqueCharacterSolution sut = new FirstUniqueCharacterSolution();
            string _Value = "success";

            int result = sut.FirstUniqueChar(_Value);

            Assert.Equal(1, result);
        }

        [Fact]
        public void ThirdExample()
        {
            FirstUniqueCharacterSolution sut = new FirstUniqueCharacterSolution();
            string _Value = "aabbccddeefff";

            int result = sut.FirstUniqueChar(_Value);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void EmptyExample()
        {
            FirstUniqueCharacterSolution sut = new FirstUniqueCharacterSolution();
            string _Value = "";

            int result = sut.FirstUniqueChar(_Value);

            Assert.Equal(-1, result);
        }
    }
}
