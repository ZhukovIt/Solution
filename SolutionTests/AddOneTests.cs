using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public sealed class AddOneTests
    {
        [Fact]
        public void FirstExample()
        {
            AddOneSolution sut = new AddOneSolution();
            int[] _Numbers = new int[]
            {
                1, 2, 3, 4
            };
            int[] _ExpectedNumbers = new int[]
            {
                1, 2, 3, 5
            };

            int[] result = sut.AddOne(_Numbers);

            Assert.Equal(_ExpectedNumbers, result);
        }

        [Fact]
        public void SecondExample()
        {
            AddOneSolution sut = new AddOneSolution();
            int[] _Numbers = new int[]
            {
                1, 9
            };
            int[] _ExpectedNumbers = new int[]
            {
                2, 0
            };

            int[] result = sut.AddOne(_Numbers);

            Assert.Equal(_ExpectedNumbers, result);
        }
    }
}
