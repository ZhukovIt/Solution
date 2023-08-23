using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class AddOneSolution
    {
        public int[] AddOne(int[] digits)
        {
            List<int> _Numbers = new List<int>() { 0 };

            foreach (int digit in digits)
            {
                _Numbers.Add(digit);
            }

            for (int i = _Numbers.Count - 1; i >= 0; i--)
            {
                if (_Numbers[i] != 9)
                {
                    _Numbers[i]++;
                    break;
                }
                else
                {
                    _Numbers[i] = 0;
                }
            }

            if (_Numbers[0] == 0)
            {
                _Numbers.RemoveAt(0);
            }

            return _Numbers.ToArray();
        } 
    }
}
