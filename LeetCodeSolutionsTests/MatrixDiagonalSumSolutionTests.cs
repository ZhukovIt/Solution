using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class MatrixDiagonalSumSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            MatrixDiagonalSumSolution sut = new MatrixDiagonalSumSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            int result = sut.DiagonalSum(matrix);

            Assert.Equal(25, result);
        }
        //---------------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            MatrixDiagonalSumSolution sut = new MatrixDiagonalSumSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1 }
            };

            int result = sut.DiagonalSum(matrix);

            Assert.Equal(8, result);
        }
        //---------------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            MatrixDiagonalSumSolution sut = new MatrixDiagonalSumSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 5 }
            };

            int result = sut.DiagonalSum(matrix);

            Assert.Equal(5, result);
        }
        //---------------------------------------------------------------------------
    }
}
