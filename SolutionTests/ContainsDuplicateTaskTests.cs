using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;
using Xunit;

namespace SolutionTests
{
    public sealed class ContainsDuplicateTaskTests
    {
        [Theory]
        [InlineData("Bazinga")]
        [InlineData("  ")]
        public void HasDuplicate(string _Value)
        {
            ContainsDuplicateTask sut = new ContainsDuplicateTask();

            bool result = sut.ContainsDuplicate(_Value);

            Assert.True(result);
        }

        [Theory]
        [InlineData("code")]
        [InlineData("")]
        public void HasNotDuplicate(string _Value)
        {
            ContainsDuplicateTask sut = new ContainsDuplicateTask();

            bool result = sut.ContainsDuplicate(_Value);

            Assert.False(result);
        }
    }
}
