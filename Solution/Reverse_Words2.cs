using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class Reverse_Words2
    {
        public string ReverseWords(string phrase)
        {
            string[] temp = phrase.Split().Select(word => new string(word.Reverse().ToArray())).ToArray();

            string result = "";

            for (int i = 0; i < temp.Length; i++)
            {
                result += temp[i];

                if (i != temp.Length - 1)
                {
                    result += " ";
                }
            }

            return result;
        }
    }
}
