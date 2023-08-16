using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class ValidPalindromeSolution
    {
        public bool IsValidPalindrome(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if (IsPalindrome(value))
            {
                return true;
            }

            for (int i = 0; i < value.Length; i++)
            {
                string _RemovedCharString = value.Remove(i, 1);

                if (IsPalindrome(_RemovedCharString))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsPalindrome(string _Value)
        {
            string _ReverseValue = new string(_Value.Reverse().ToArray());

            return _Value == _ReverseValue;
        }
    }
}
