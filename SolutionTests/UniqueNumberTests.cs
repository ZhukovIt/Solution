using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public sealed class UniqueNumberTests
    {
        [Fact]
        public void FirstExample()
        {
            UniqueNumberSolution sut = new UniqueNumberSolution();
            int[] array = new int[]
            {
                3,
                1,
                3
            };

            int result = sut.UniqueNumber(array);

            Assert.Equal(1, result);
        }

        [Fact]
        public void SecondExample()
        {
            UniqueNumberSolution sut = new UniqueNumberSolution();
            int[] array = new int[]
            {
                5,
                7,
                0,
                5,
                0
            };

            int result = sut.UniqueNumber(array);

            Assert.Equal(7, result);
        }

        [Fact]
        public void EmptyArrayExample()
        {
            UniqueNumberSolution sut = new UniqueNumberSolution();
            int[] array = new int[0];

            int result = sut.UniqueNumber(array);

            Assert.Equal(-1, result);
        }
    }
}
