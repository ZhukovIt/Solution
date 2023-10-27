using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolutionsTests
{
    public sealed class AverageSalaryExcludingTheMinimumAndMaximumSalarySolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            AverageSalaryExcludingTheMinimumAndMaximumSalarySolution sut = new AverageSalaryExcludingTheMinimumAndMaximumSalarySolution();
            int[] salary = new int[]
            {
                4000, 3000, 1000, 2000
            };

            double result = sut.Average(salary);

            Assert.True(Math.Abs(result - 2500.00000) < 0.00001);
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            AverageSalaryExcludingTheMinimumAndMaximumSalarySolution sut = new AverageSalaryExcludingTheMinimumAndMaximumSalarySolution();
            int[] salary = new int[]
            {
                1000, 2000, 3000
            };

            double result = sut.Average(salary);

            Assert.True(Math.Abs(result - 2000.00000) < 0.00001);
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            AverageSalaryExcludingTheMinimumAndMaximumSalarySolution sut = new AverageSalaryExcludingTheMinimumAndMaximumSalarySolution();
            int[] salary = new int[]
            {
                48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 
                33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000
            };

            double result = sut.Average(salary);

            Assert.True(Math.Abs(result - 41111.11111) < 0.00001);
        }
        //------------------------------------------------------------------------------------
    }
}
