using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class RichestCustomerWealthSolution
    {
        public int MaximumWealth(int[][] accounts)
        {
            return accounts.Max(acc => acc.Sum());
        }
    }
}
