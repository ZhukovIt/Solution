using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class MatrixDiagonalSumSolution
    {
        public int DiagonalSum(int[][] mat)
        {
            if (mat.Length == 1)
                return mat[0][0];

            int result = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                result += mat[i][i] + mat[i][mat.Length - i - 1];
            }

            if (mat.Length % 2 != 0)
                return result - mat[mat.Length / 2][mat.Length / 2];
            return result;
        }
    }
}
