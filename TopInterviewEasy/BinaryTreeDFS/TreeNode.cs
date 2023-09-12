using System;
namespace LeetCode.Pruebas
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
}

