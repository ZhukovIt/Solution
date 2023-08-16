using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class ContainsDuplicateTask
    {
        public bool ContainsDuplicate(string value)
        {
            if (value.Length == 0)
            {
                return false;
            }

            var _Dict = new Dictionary<char, int>();

            foreach (char c in value)
            {
                if (!_Dict.ContainsKey(c))
                {
                    _Dict.Add(c, 0);
                }

                _Dict[c] += 1;
            }

            foreach (KeyValuePair<char, int> pair in _Dict)
            {
                if (pair.Value > 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
