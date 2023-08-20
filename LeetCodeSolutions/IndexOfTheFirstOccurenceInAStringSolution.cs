using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class IndexOfTheFirstOccurenceInAStringSolution
    {
        // 1 <= haystack.length, needle.length <= 10^4
        // haystack and needle consist of only lowercase English characters.

        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
