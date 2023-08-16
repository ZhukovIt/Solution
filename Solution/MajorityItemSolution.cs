using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class MajorityItemSolution
    {
        public int MajorityItem(int[] array)
        {
            var _Dict = new Dictionary<int, int>();

            foreach (int item in array)
            {
                if (!_Dict.ContainsKey(item))
                {
                    _Dict.Add(item, 0);
                }

                _Dict[item] += 1;
            }

            return _Dict.First(x => x.Value == _Dict.Max(pair => pair.Value)).Key;
        }
    }
}
