using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class SetMatrixZeroesSolution
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length == 1 && matrix[0].Length == 1)
                return;

            if (matrix.Length == 1)
            {
                if (matrix[0].Any(x => x == 0))
                {
                    for (int i = 0; i < matrix[0].Length; i++)
                    {
                        matrix[0][i] = 0;
                    }
                }
                return;
            }
            else if (matrix[0].Length == 1)
            {
                if (matrix.Any(x => x[0] == 0))
                {
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        matrix[i][0] = 0;
                    }
                }
                return;
            }

            bool matrixContainsOnlyZeroElements = false;
            List<int> valueList = CreateValueList(matrix[0].Length, matrix.Length);
            for (int i = 0; i < matrix.Length; i++)
            {
                if (valueList.All(x => x == 0))
                    matrixContainsOnlyZeroElements = true;

                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (!matrixContainsOnlyZeroElements && matrix[i][j] == 0)
                    {
                        valueList[j] = 0;
                        SetZeroInColumns(valueList, (int)Math.Pow(2, i));
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrixContainsOnlyZeroElements)
                    {
                        matrix[i][j] = 0;
                    }
                    else
                    {
                        matrix[i][j] = matrix[i][j] * ((valueList[j] & (int)Math.Pow(2, i)) != 0 ? 1 : 0);
                    }
                }
            }
        }
        //-----------------------------------------------------
        private static List<int> CreateValueList(int _CountColumns, int _CountRows)
        {
            int maxFlagValue = 0;
            for (int i = 0; i < _CountRows; i++)
            {
                maxFlagValue += (int)Math.Pow(2, i);
            }

            List<int> result = new List<int>(_CountColumns);

            for (int i = 0; i < _CountColumns; i++)
            {
                result.Add(maxFlagValue);
            }

            return result;
        }
        //-----------------------------------------------------
        private static void SetZeroInColumns(List<int> valueMatrix, int deleteValue)
        {
            for (int i = 0; i < valueMatrix.Count; i++)
            {
                if (valueMatrix[i] != 0 && (valueMatrix[i] & deleteValue) != 0)
                    valueMatrix[i] ^= deleteValue;
            }
        }
        //-----------------------------------------------------
    }
}
