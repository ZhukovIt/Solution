using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class ValidAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            var _FirstDict = GetAnagramDict(s);
            var _SecondDict = GetAnagramDict(t);

            return DictsIsEqual(_FirstDict, _SecondDict);
        }

        private Dictionary<char, int> GetAnagramDict(string _Str)
        {
            var _Result = new Dictionary<char, int>();

            foreach (char c in _Str)
            {
                if (!_Result.ContainsKey(c))
                {
                    _Result[c] = 0;
                }

                _Result[c]++;
            }

            return _Result;
        }

        private bool DictsIsEqual(Dictionary<char, int> _FirstDict, Dictionary<char, int> _SecondDict)
        {
            if (_FirstDict.Keys.Count != _SecondDict.Keys.Count)
            {
                return false;
            }

            foreach (KeyValuePair<char, int> pair in _FirstDict)
            {
                if (!_SecondDict.ContainsKey(pair.Key))
                {
                    return false;
                }
                else if (_SecondDict[pair.Key] != pair.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
