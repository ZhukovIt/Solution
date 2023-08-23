using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class ArraysIntersection2Solution
    {
        public int[] Intersect(int[] array1, int[] array2)
        {
            List<int> _LargestArray;
            List<int> _SmallestArray;

            if (array1.Length >= array2.Length)
            {
                _LargestArray = array1.ToList();
                _SmallestArray = array2.ToList();
            }
            else
            {
                _LargestArray = array2.ToList();
                _SmallestArray = array1.ToList();
            }

            List<int> _Result = new List<int>();

            foreach (int digit in _SmallestArray)
            {
                if (_LargestArray.Contains(digit))
                {
                    _Result.Add(digit);
                    _LargestArray.Remove(digit);
                }
            }

            return _Result.ToArray();
        }
    }
}
