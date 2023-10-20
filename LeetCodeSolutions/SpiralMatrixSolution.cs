using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class SpiralMatrixSolution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return new List<int>();

            if (matrix.Length == 1 && matrix[0].Length == 1)
                return new List<int>() { matrix[0][0] };

            List<int> result = new List<int>();
            int n = matrix.Length, m = matrix[0].Length,
                i1 = 0, i2 = 0, j1 = 0, j2 = 0, currentNumber;

            Func<int, bool> addNewValueAndCheckStopDelegate = new Func<int, bool>((int number) => 
            {
                result.Add(number);
                return result.Count >= n * m;
            });

            while (result.Count < n * m)
            {
                for (int j = j1; j < m - j2; j++)
                {
                    currentNumber = matrix[i1][j];
                    if (addNewValueAndCheckStopDelegate.Invoke(currentNumber))
                        return result;
                }
                i1++;

                for (int i = i1; i < n - i2; i++)
                {
                    currentNumber = matrix[i][m - j2 - 1];
                    if (addNewValueAndCheckStopDelegate.Invoke(currentNumber))
                        return result;
                }
                j2++;

                for (int j = m - j2 - 1; j >= j1; j--)
                {
                    currentNumber = matrix[n - i2 - 1][j];
                    if (addNewValueAndCheckStopDelegate.Invoke(currentNumber))
                        return result;
                }
                i2++;

                for (int i = n - i2 - 1; i >= i1; i--)
                {
                    currentNumber = matrix[i][j1];
                    if (addNewValueAndCheckStopDelegate.Invoke(currentNumber))
                        return result;
                }
                j1++;
            }

            return result;
        }
    }
}
