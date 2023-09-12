using System;
namespace LeetCode.BinaryTreeDFS
{
	public class LeafSimilar
	{
		public LeafSimilar()
		{
		}

        public bool leafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> sequence1 = new List<int>();
            List<int> sequence2 = new List<int>();

            getLeaf(root1, sequence1);
            getLeaf(root2, sequence2);

            return sequence1.SequenceEqual(sequence2);
        }

        public static void getLeaf(TreeNode root, List<int> list)
        {
            if (root == null) return;
            if (root.left == null && root.right == null)
            {
                list.Add(root.val);
            }
            getLeaf(root.left, list);
            getLeaf(root.right, list);

            return;
        }

    }
}

//Ejemplo para probar

//TreeNode nodo11 = new TreeNode(11, null, null);
//TreeNode nodo10 = new TreeNode(10, null, null);
//TreeNode nodo9 = new TreeNode(9, null, null);
//TreeNode nodo8 = new TreeNode(8, null, null);
//TreeNode nodo7 = new TreeNode(7, null, nodo11);
//TreeNode nodo6 = new TreeNode(6, null, nodo10);
//TreeNode nodo5 = new TreeNode(5, null, null);
//TreeNode nodo4 = new TreeNode(4, nodo8, nodo9);
//TreeNode nodo3 = new TreeNode(3, nodo6, nodo7);
//TreeNode nodo2 = new TreeNode(2, nodo4, nodo5);
//TreeNode nodo1 = new TreeNode(1, nodo2, nodo3);

