using System;
namespace LeetCode.TopInterviewEasy.Trees
{
	public class IsSymmetric
	{
		public IsSymmetric()
		{
		}

        public bool isSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return isSymmetric(root.left, root.right);
        }

        public bool isSymmetric(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode == null || rightNode == null)
                return leftNode == rightNode;

            if (leftNode.val != rightNode.val) return false;

            return isSymmetric(leftNode.left, rightNode.right) &&
                   isSymmetric(leftNode.right, rightNode.left);
        }
    }
}

