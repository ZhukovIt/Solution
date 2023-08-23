using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("SolutionTests")]

namespace Solution
{
    public sealed class CountBitsSolution
    {
        public int[] CountBits(int value)
        {
            List<int> _Result = new List<int>();

            for (int i = 0; i <= value; i++)
            {
                _Result.Add(CalculateCountBitsFromNumber(i));
            }

            return _Result.ToArray();
        }

        internal int CalculateCountBitsFromNumber(int _Number)
        {
            int _Counter = 0;

            while (_Number >= 2)
            {
                _Counter += _Number % 2;
                _Number /= 2;
            }

            if (_Number == 1)
            {
                _Counter++;
            }

            return _Counter;
        }
    }
}
