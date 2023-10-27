using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class AverageSalaryExcludingTheMinimumAndMaximumSalarySolution
    {
        public double Average(int[] salary)
        {
            int max = int.MinValue, min = int.MaxValue, result = 0;

            foreach (int sal in salary)
            {
                result += sal;
                if (sal > max)
                    max = sal;
                if (sal < min)
                    min = sal;
            }

            return (result - max - min) / ((double)salary.Length - 2);
        }
    }
}
