using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class FirstUniqueCharacterSolution
    {
        public int FirstUniqueChar(string value)
        {
            var _Dict = new Dictionary<char, int>();

            foreach (char c in value)
            {
                if (!_Dict.ContainsKey(c))
                {
                    _Dict.Add(c, 0);
                }

                _Dict[c] += 1;
            }

            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];

                if (_Dict[c] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
