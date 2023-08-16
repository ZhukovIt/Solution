using Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SolutionTests
{
    public sealed class Reverse_Words2Tests
    {
        [Theory]
        [InlineData("Everybody lies", "ydobyrevE seil")]
        [InlineData("Go ahead, make my day", "oG ,daeha ekam ym yad")]
        public void Reverse_Phrase_And_Reverses_Each_Word_In_The_Phrase(string _Phrase, string _Expected)
        {
            Reverse_Words2 sut = new Reverse_Words2();

            string result = sut.ReverseWords(_Phrase);

            Assert.Equal(_Expected, result);
        }
    }
}
