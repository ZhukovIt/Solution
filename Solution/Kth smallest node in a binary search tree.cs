using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class Kth_smallest_node_in_a_binary_search_tree_Solution
    {
        public int KthSmallestValue(TreeNode root, int k)
        {
            TreeNodeWorker _TreeNodeWorker = new TreeNodeWorker(root);

            int[] _NumbersContainer = _TreeNodeWorker.NumbersContainer.OrderBy(x => x).ToArray();

            return _NumbersContainer[k - 1];
        }
    }
}
