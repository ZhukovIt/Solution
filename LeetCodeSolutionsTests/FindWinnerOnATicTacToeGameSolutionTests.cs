using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class FindWinnerOnATicTacToeGameSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            FindWinnerOnATicTacToeGameSolution sut = new FindWinnerOnATicTacToeGameSolution();
            int[][] moves = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 2, 0 },
                new int[] { 1, 1 },
                new int[] { 2, 1 },
                new int[] { 2, 2 }
            };

            string result = sut.Tictactoe(moves);

            Assert.Equal("A", result);
        }
        //----------------------------------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            FindWinnerOnATicTacToeGameSolution sut = new FindWinnerOnATicTacToeGameSolution();
            int[][] moves = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 0 },
                new int[] { 2, 0 }
            };

            string result = sut.Tictactoe(moves);

            Assert.Equal("B", result);
        }
        //----------------------------------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            FindWinnerOnATicTacToeGameSolution sut = new FindWinnerOnATicTacToeGameSolution();
            int[][] moves = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 2, 0 },
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 2, 2 }
            };

            string result = sut.Tictactoe(moves);

            Assert.Equal("Draw", result);
        }
        //----------------------------------------------------------------------------------------------
        [Fact]
        public void FourthExample()
        {
            FindWinnerOnATicTacToeGameSolution sut = new FindWinnerOnATicTacToeGameSolution();
            int[][] moves = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 2, 0 },
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 0, 1 },
                new int[] { 0, 2 }
            };

            string result = sut.Tictactoe(moves);

            Assert.Equal("Pending", result);
        }
        //----------------------------------------------------------------------------------------------
        [Fact]
        public void FivethExample()
        {
            FindWinnerOnATicTacToeGameSolution sut = new FindWinnerOnATicTacToeGameSolution();
            int[][] moves = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 1, 0 },
                new int[] { 0, 0 },
                new int[] { 0, 1 },
                new int[] { 2, 0 },
                new int[] { 1, 1 }
            };

            string result = sut.Tictactoe(moves);

            Assert.Equal("A", result);
        }
        //----------------------------------------------------------------------------------------------
    }
}
