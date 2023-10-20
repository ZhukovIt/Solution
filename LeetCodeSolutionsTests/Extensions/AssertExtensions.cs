using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionsTests.Extensions
{
    public static class AssertExtensions
    {
        public static void AssertCollectionsIsEqual<T>(this IEnumerable<T> _Self, IEnumerable<T> _Other)
        {
            bool checkResult = true;

            if (_Self.Count() != _Other.Count())
            {
                checkResult = false;
            }
            else
            {
                var _IndexedSelf = _Self.Select((el, index) => new { el, index });
                var _IndexedOther = _Other.Select((el, index) => new { el, index });

                for (int i = 0; i < _Self.Count(); i++)
                {
                    if (!_IndexedSelf.First(x => x.index == i).el.Equals(_IndexedOther.First(x => x.index == i).el))
                    {
                        checkResult = false;
                        break;
                    }
                }
            }
            Assert.True(checkResult);
        }
    }
}
