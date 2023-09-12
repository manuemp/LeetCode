using System;
namespace LeetCode.BinaryTreeDFS
{
	public class PathSum
	{
		public PathSum()
		{
		}

		public int pathSum(TreeNode root, int targetSum)
		{
			if (root == null) return 0;

			if (root.val == targetSum) return 1;
			if (root.val < targetSum)
			{
				pathSum(root.left, (targetSum - root.val));
				pathSum(root.left, (targetSum - root.val));
			}
			else
			{
				pathSum(root.left, targetSum);
                pathSum(root.right, targetSum);
            }

            return 0;
		}
	}
}

