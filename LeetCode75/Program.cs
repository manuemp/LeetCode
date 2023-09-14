// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using LeetCode.Pruebas;
using LeetCode.TopInterviewEasy.Strings;
using LeetCode.TopInterviewEasy.LinkedLists;

namespace LeetCode
{

    class Program
    {

        static void Main(string[] args)
        {
            TreeNode nodo7 = new TreeNode(3, null, null);
            TreeNode nodo6 = new TreeNode(4, null, null);
            TreeNode nodo5 = new TreeNode(4, null, null);
            TreeNode nodo4 = new TreeNode(3, null, null);
            TreeNode nodo3 = new TreeNode(2, nodo6, nodo7);
            TreeNode nodo2 = new TreeNode(2, nodo4, nodo5);
            TreeNode root = new TreeNode(1, nodo2, nodo3);

            Console.WriteLine(isValidBST(root));

            Console.ReadKey();
        }

       public static bool isSymmetric(TreeNode root)
        {
            List<List<int>> treeList = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> subList = new List<int>();
                int len = queue.Count;
                for (int i = 0; i < len; i++)
                {
                    TreeNode aux = queue.Dequeue();
                    if (aux != null)
                    {
                        subList.Add(aux.val);
                        queue.Enqueue(aux.left);
                        queue.Enqueue(aux.right);
                    }
                }
                if (subList.Count > 0) treeList.Add(subList);
            }
            return true;
        }

    }

}







