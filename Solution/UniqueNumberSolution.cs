using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class UniqueNumberSolution
    {
        public int UniqueNumber(int[] array)
        {
            var _Dict = new Dictionary<int, int>();

            foreach (int number in array)
            {
                if (!_Dict.ContainsKey(number))
                {
                    _Dict.Add(number, 0);
                }

                _Dict[number] += 1;
            }

            foreach (KeyValuePair<int, int> pair in _Dict)
            {
                if (pair.Value == 1)
                {
                    return pair.Key;
                }
            }

            return -1;
        }
    }
}
