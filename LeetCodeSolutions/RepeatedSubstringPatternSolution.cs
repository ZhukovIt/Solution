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
            bool _Result = false;
            StringBuilder sb = new StringBuilder();
            int _Counter = 0;

            while (!_Result)
            {
                sb.Append(s[_Counter]);

                if (s.Length % sb.Length == 0)
                {

                }

                _Counter++;
            }

            return _Result;
        }
    }
}
