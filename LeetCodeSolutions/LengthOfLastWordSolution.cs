using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            int result = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && result > 0)
                    return result;

                if (s[i] != ' ')
                {
                    result++;
                }
            }

            return result;
        }
    }
}
