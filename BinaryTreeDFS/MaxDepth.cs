using System;
using LeetCode.Pruebas;

namespace LeetCode.BinaryTreeDFS
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode()
        {
            this.val = 0;
            this.left = null;
            this.right = null;
        }
    }

    public class MaxDepth
	{
		public MaxDepth()
		{
		}

        public static int maxDepth(TreeNode root)
        {
            if (root == null) return 0;
            int left = maxDepth(root.left);
            int right = maxDepth(root.right);

            return Math.Max(left, right) + 1;
        }

        //public int MaxDepth(TreeNode root)
        //{

        //    if (root == null) return 0;
        //    int right = 1;
        //    int left = 1;

        //    if (root.left != null)
        //        left += MaxDepth(root.left);

        //    if (root.right != null)
        //        right += MaxDepth(root.right);

        //    return Math.Max(left, right);
        //}
    }
}

