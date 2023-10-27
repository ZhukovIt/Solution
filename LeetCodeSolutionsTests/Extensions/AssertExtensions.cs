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
        public static void AssertCollectionsIsEqual<TElement>(this IEnumerable<TElement> _Self, IEnumerable<TElement> _Other)
        {
            Assert.True(EqualsCollections(_Self, _Other));
        }
        //----------------------------------------------------------------------------------------------------------------
        private static bool EqualsCollections<TElement>(IEnumerable<TElement> _Self, IEnumerable<TElement> _Other)
        {
            bool checkResult = true;

            if (_Self.Count() != _Other.Count())
            {
                checkResult = false;
            }
            else if (_Self.Count() == 0)
            {
                checkResult = true;
            }
            else
            {
                var _IndexedSelf = _Self.Select((el, index) => new { el, index });
                var _IndexedOther = _Other.Select((el, index) => new { el, index });

                for (int i = 0; i < _Self.Count(); i++)
                {
                    if (_IndexedSelf.First(x => x.index == i).el is IEnumerable<int> indexedSelfElem &&
                        _IndexedOther.First(x => x.index == i).el is IEnumerable<int> indexedOtherElem &&
                        EqualsCollections(indexedSelfElem, indexedOtherElem))
                        continue;

                    if (!_IndexedSelf.First(x => x.index == i).el.Equals(_IndexedOther.First(x => x.index == i).el))
                    {
                        checkResult = false;
                        break;
                    }
                }
            }

            return checkResult;
        }
        //----------------------------------------------------------------------------------------------------------------
    }
}
