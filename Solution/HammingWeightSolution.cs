using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class HammingWeightSolution
    {
        public int HammingWeight(uint value)
        {
            List<uint> _PowersOfTwo = new List<uint>();

            for (int i = 0; i <= 32; i++)
            {
                _PowersOfTwo.Add((uint)Math.Pow(2, i));
            }

            int counter = 0;

            foreach (int powerOfTwo in _PowersOfTwo)
            {
                if ((value & powerOfTwo) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
