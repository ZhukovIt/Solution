using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class FindTheDifferenceSolution
    {
        public char FindTheDifference(string s, string t)
        {
            var _FirstDict = GetCharsDict(s);
            var _SecondDict= GetCharsDict(t);

            foreach (KeyValuePair<char, int> pair in _SecondDict)
            {
                char _Key = pair.Key;
                int _Value = pair.Value;

                if (!_FirstDict.ContainsKey(_Key))
                {
                    return _Key;
                }
                else if (_Value > _FirstDict[_Key]) 
                {
                    return _Key; 
                }
            }

            return default;
        }

        private Dictionary<char, int> GetCharsDict(string _Str)
        {
            var _Result = new Dictionary<char, int>();

            foreach (char c in _Str)
            {
                if (!_Result.ContainsKey(c))
                {
                    _Result[c] = 0;
                }

                _Result[c] += 1;
            }

            return _Result;
        }
    }
}
