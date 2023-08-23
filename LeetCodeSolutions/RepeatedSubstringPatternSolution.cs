using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class RepeatedSubstringPatternSolution
    {
        public bool RepeatedSubstringPattern(string s)
        {
            int _Length = s.Length;

            for (int i = _Length / 2; i >= 1; i--)
            {
                if (_Length % i == 0)
                {
                    string _SubStr = s.Substring(0, i);
                    StringBuilder sb = new StringBuilder();

                    for (int j = 0; j < _Length / i; j++)
                    {
                        sb.Append(_SubStr);
                    }

                    if (sb.ToString() == s)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
