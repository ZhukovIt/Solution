using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] array)
        {
            if (array.Length == 0)
            {
                return "";
            }
            else if (array.Length == 1)
            {
                return array.First();
            }
            else
            {
                string _First = array.First();
                int counter = 0;
                string _TempResult = _First[counter].ToString();
                string _Result = _TempResult;

                while (array.All(x => x.StartsWith(_TempResult)))
                {
                    counter++;
                    _TempResult += _First[counter].ToString();
                    if (array.All(x => x.StartsWith(_TempResult)))
                    {
                        _Result = _TempResult;
                    }
                }

                return _Result;
            }
        }
    }
}
