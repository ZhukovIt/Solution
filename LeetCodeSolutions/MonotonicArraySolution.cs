using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class MonotonicArraySolution
    {
        private Func<int, int, bool> m_CheckMonotonic = null;
        //-------------------------------------------------------
        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length <= 1)
                return true;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    continue;

                if (m_CheckMonotonic == null)
                {
                    if (nums[i] < nums[i + 1])
                    {
                        m_CheckMonotonic = (int first, int second) => first < second;
                    }
                    else
                    {
                        m_CheckMonotonic = (int first, int second) => first > second;
                    }
                }

                if (!m_CheckMonotonic.Invoke(nums[i], nums[i + 1]))
                    return false;
            }

            return true;
        }
        //-------------------------------------------------------
    }
}
