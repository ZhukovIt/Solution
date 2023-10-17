using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class RichestCustomerWealthSolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            RichestCustomerWealthSolution sut = new RichestCustomerWealthSolution();
            int[][] accounts = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 }
            };

            int result = sut.MaximumWealth(accounts);

            Assert.Equal(6, result);
        }
        //----------------------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            RichestCustomerWealthSolution sut = new RichestCustomerWealthSolution();
            int[][] accounts = new int[][]
            {
                new int[] { 1, 5 },
                new int[] { 7, 3 },
                new int[] { 3, 5 }
            };

            int result = sut.MaximumWealth(accounts);

            Assert.Equal(10, result);
        }
        //----------------------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            RichestCustomerWealthSolution sut = new RichestCustomerWealthSolution();
            int[][] accounts = new int[][]
            {
                new int[] { 2, 8, 7 },
                new int[] { 7, 1, 3 },
                new int[] { 1, 9, 5 }
            };

            int result = sut.MaximumWealth(accounts);

            Assert.Equal(17, result);
        }
        //----------------------------------------------------------------------------------
    }
}
