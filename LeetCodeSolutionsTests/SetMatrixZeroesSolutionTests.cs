using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using LeetCodeSolutionsTests.Extensions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class SetMatrixZeroesSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            SetMatrixZeroesSolution sut = new SetMatrixZeroesSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 }
            };

            sut.SetZeroes(matrix);

            matrix.AssertCollectionsIsEqual(new int[][]
            {
                new int[] { 1, 0, 1 },
                new int[] { 0, 0, 0 },
                new int[] { 1, 0, 1 }
            });
        }
        //--------------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            SetMatrixZeroesSolution sut = new SetMatrixZeroesSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 0, 1, 2, 0 },
                new int[] { 3, 4, 5, 2 },
                new int[] { 1, 3, 1, 5 }
            };

            sut.SetZeroes(matrix);

            matrix.AssertCollectionsIsEqual(new int[][]
            {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 4, 5, 0 },
                new int[] { 0, 3, 1, 0 }
            });
        }
        //--------------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            SetMatrixZeroesSolution sut = new SetMatrixZeroesSolution();
            int[][] matrix = new int[][]
            {
                new int[] { -1 },
                new int[] { 2 },
                new int[] { 3 }
            };

            sut.SetZeroes(matrix);

            matrix.AssertCollectionsIsEqual(new int[][]
            {
                new int[] { -1 },
                new int[] { 2 },
                new int[] { 3 }
            });
        }
        //--------------------------------------------------------------------------
        [Fact]
        public void FourthExample()
        {
            SetMatrixZeroesSolution sut = new SetMatrixZeroesSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1 },
                new int[] { 3 },
                new int[] { 0 }
            };

            sut.SetZeroes(matrix);

            matrix.AssertCollectionsIsEqual(new int[][]
            {
                new int[] { 0 },
                new int[] { 0 },
                new int[] { 0 }
            });
        }
        //--------------------------------------------------------------------------
        [Fact]
        public void FivethExample()
        {
            SetMatrixZeroesSolution sut = new SetMatrixZeroesSolution();
            int[][] matrix = new int[][]
            {
                new int[] { -3, 0, -6, -4 },
                new int[] { 7, 0, -10, -1 },
                new int[] { -2147483648, -3, 4, -2 },
                new int[] { 5, 2, 4, 2147483647 },
                new int[] { 8, 10, -7, -5 }
            };

            sut.SetZeroes(matrix);

            matrix.AssertCollectionsIsEqual(new int[][]
            {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { -2147483648, 0, 4, -2 },
                new int[] { 5, 0, 4, 2147483647 },
                new int[] { 8, 0, -7, -5 }
            });
        }
        //--------------------------------------------------------------------------
    }
}
