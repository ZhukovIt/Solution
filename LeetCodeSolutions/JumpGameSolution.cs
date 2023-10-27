using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class JumpGameSolution
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length <= 1)
                return true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i == nums.Length - 1)
                    return false;
                if (i + nums[i] >= nums.Length - 1)
                    return true;
            }
            return false;
        }
    }
}
