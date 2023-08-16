using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public sealed class TreeNodeWorker
    {
        private readonly List<int> m_NumbersContainer;
        //------------------------------------------------------
        public IEnumerable<int> NumbersContainer
        {
            get
            {
                return m_NumbersContainer;
            }
        }
        //------------------------------------------------------
        public TreeNodeWorker(TreeNode _Node)
        {
            m_NumbersContainer = new List<int>();
            FillNumbersContainerFromNode(_Node);
        }
        //------------------------------------------------------
        public void FillNumbersContainerFromNode(TreeNode _Node)
        {
            m_NumbersContainer.Add(_Node.Value);

            if (_Node.Left == null && _Node.Right == null)
            {
                return;
            }
            
            if (_Node.Left != null)
            {
                FillNumbersContainerFromNode(_Node.Left);
            }

            if (_Node.Right != null)
            {
                FillNumbersContainerFromNode(_Node.Right);
            }
        }
        //------------------------------------------------------
    }
}
