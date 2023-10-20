using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;
using LeetCodeSolutionsTests.Extensions;

namespace LeetCodeSolutionsTests
{
    public sealed class SpiralMatrixSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            SpiralMatrixSolution sut = new SpiralMatrixSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            IList<int> result = sut.SpiralOrder(matrix);

            result.AssertCollectionsIsEqual(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 });
        }
        //------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            SpiralMatrixSolution sut = new SpiralMatrixSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 }
            };

            IList<int> result = sut.SpiralOrder(matrix);

            result.AssertCollectionsIsEqual(new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 });
        }
        //------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            SpiralMatrixSolution sut = new SpiralMatrixSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8, 9, 10 },
                new int[] { 11, 12, 13, 14, 15 },
                new int[] { 16, 17, 18, 19, 20 }
            };

            IList<int> result = sut.SpiralOrder(matrix);

            result.AssertCollectionsIsEqual(new int[] { 1, 2, 3, 4, 5, 10, 15, 20, 19, 18, 17, 16, 11, 6, 7, 8, 9, 14, 13, 12 });
        }
        //------------------------------------------------------------------
        [Fact]
        public void FourthExample()
        {
            SpiralMatrixSolution sut = new SpiralMatrixSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5, 6 }
            };

            IList<int> result = sut.SpiralOrder(matrix);

            result.AssertCollectionsIsEqual(new int[] { 1, 2, 3, 4, 5, 6 });
        }
        //------------------------------------------------------------------
        [Fact]
        public void FivethExample()
        {
            SpiralMatrixSolution sut = new SpiralMatrixSolution();
            int[][] matrix = new int[][] { };

            IList<int> result = sut.SpiralOrder(matrix);

            result.AssertCollectionsIsEqual(new int[0] { });
        }
        //------------------------------------------------------------------
        [Fact]
        public void SixthExample()
        {
            SpiralMatrixSolution sut = new SpiralMatrixSolution();
            int[][] matrix = new int[][] { new int[] { } };

            IList<int> result = sut.SpiralOrder(matrix);

            result.AssertCollectionsIsEqual(new int[0] { });
        }
        //------------------------------------------------------------------
        [Fact]
        public void SeventhExample()
        {
            SpiralMatrixSolution sut = new SpiralMatrixSolution();
            int[][] matrix = new int[][] { new int[] { 1 } };

            IList<int> result = sut.SpiralOrder(matrix);

            result.AssertCollectionsIsEqual(new int[] { 1 });
        }
        //------------------------------------------------------------------
        [Fact]
        public void EighthExample()
        {
            SpiralMatrixSolution sut = new SpiralMatrixSolution();
            int[][] matrix = new int[][] 
            { 
                new int[] { 3 },
                new int[] { 2 }
            };

            IList<int> result = sut.SpiralOrder(matrix);

            result.AssertCollectionsIsEqual(new int[] { 3, 2 });
        }
        //------------------------------------------------------------------
    }
}
