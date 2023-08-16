using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public class HammingWeightTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(10)]
        public void HammingWeightEqualTwo(uint _Value)
        {
            HammingWeightSolution sut = new HammingWeightSolution();

            int result = sut.HammingWeight(_Value);

            Assert.Equal(2, result);
        }
    }
}
