using Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SolutionTests
{
    public sealed class Kth_smallest_node_in_a_binary_search_tree_SolutionTests
    {
        [Fact]
        public void FirstExample()
        {
            TreeNode _Root = new TreeNode(3)
            {
                Left = new TreeNode(2),
                Right = new TreeNode(8)
            };
            int k = 1;
            int expected = 2;
            var sut = new Kth_smallest_node_in_a_binary_search_tree_Solution();

            int result = sut.KthSmallestValue(_Root, k);

            Assert.Equal(expected, result);
        }
        //----------------------------------------------------------------------------
        [Fact]
        public void SecondExample()
        {
            TreeNode _Root = new TreeNode(3)
            {
                Left = new TreeNode(2),
                Right = new TreeNode(8)
            };
            int k = 2;
            int expected = 3;
            var sut = new Kth_smallest_node_in_a_binary_search_tree_Solution();

            int result = sut.KthSmallestValue(_Root, k);

            Assert.Equal(expected, result);
        }
        //----------------------------------------------------------------------------
        [Fact]
        public void ThirdExample()
        {
            TreeNode _Root = new TreeNode(3)
            {
                Left = new TreeNode(1)
                {
                    Right = new TreeNode(2)
                },
                Right = new TreeNode(5)
            };
            int k = 2;
            int expected = 2;
            var sut = new Kth_smallest_node_in_a_binary_search_tree_Solution();

            int result = sut.KthSmallestValue(_Root, k);

            Assert.Equal(expected, result);
        }
        //----------------------------------------------------------------------------
    }
}
