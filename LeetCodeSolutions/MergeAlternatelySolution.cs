using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class MergeAlternatelySolution
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder _Result = new StringBuilder();
            int _FirstPtr = 0;
            int _SecondPtr = 0;
            bool _GetCharFromFirstWord = true;

            while (_FirstPtr < word1.Length ||  _SecondPtr < word2.Length)
            {
                if (_GetCharFromFirstWord)
                {
                    if (_FirstPtr < word1.Length)
                    {
                        _Result.Append(word1[_FirstPtr]);
                        _FirstPtr++;
                    }
                    else if (_SecondPtr < word2.Length)
                    {
                        _Result.Append(word2[_SecondPtr]);
                        _SecondPtr++;
                    }
                }
                else
                {
                    if (_SecondPtr < word2.Length)
                    {
                        _Result.Append(word2[_SecondPtr]);
                        _SecondPtr++;
                    }
                    else if (_FirstPtr < word1.Length)
                    {
                        _Result.Append(word1[_FirstPtr]);
                        _FirstPtr++;
                    }
                }

                _GetCharFromFirstWord = !_GetCharFromFirstWord;
            }

            return _Result.ToString();
        }
    }
}
