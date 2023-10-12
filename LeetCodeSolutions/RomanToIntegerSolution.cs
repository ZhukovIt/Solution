using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            int flag = 0;

            Dictionary<char, int> numbers = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    if (flag == 0)
                    {
                        
                    }
                    else if (flag == 1)
                    {
                        result -= 1;
                    }
                    else if (flag == 2)
                    {
                        if (numbers[s[i]] < 10)
                        {
                            result += 10;
                        }
                        else
                        {
                            result -= 10;
                        }
                    }
                    else if (flag == 4)
                    {
                        if (numbers[s[i]] < 100)
                        {
                            result += 100;
                        }
                        else
                        {
                            result -= 100;
                        }
                    }

                    result += numbers[s[i]];
                    break;
                }

                if (flag > 0)
                {
                    if ((flag & 1) != 0)
                    {
                        if (s[i] == 'V')
                        {
                            result += 4;
                        }
                        else if (s[i] == 'X')
                        {
                            result += 9;
                        }
                        else
                        {
                            result += numbers[s[i]] + 1;
                        }
                    }
                    else if ((flag & 2) != 0)
                    {
                        if (s[i] == 'L')
                        {
                            result += 40;
                        }
                        else if (s[i] == 'C')
                        {
                            result += 90;
                        }
                        else
                        {
                            result += numbers[s[i]] + 10;
                        }
                    }
                    else if ((flag & 4) != 0)
                    {
                        if (s[i] == 'D')
                        {
                            result += 400;
                        }
                        else if (s[i] == 'M')
                        {
                            result += 900;
                        }
                        else
                        {
                            result += numbers[s[i]] + 100;
                        }
                    }

                    flag = 0;
                }
                else
                {
                    switch (s[i])
                    {
                        case 'I':
                            flag = 1; break;
                        case 'X':
                            flag = 2; break;
                        case 'C':
                            flag = 4; break;
                        default:
                            flag = 0; break;
                    }

                    if (flag == 0)
                        result += numbers[s[i]];
                }
            }

            return result;
        }
    }
}
