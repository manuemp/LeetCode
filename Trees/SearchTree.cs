using System;
namespace LeetCode.Trees
{
	public class SearchTree
	{

        //Se necesita saber si existe dentro del árbol un nodo con valor igual a 'val'
        //En caso de que exista, hay que devolver el subárbol que se genera a partir
        //de ese nodo. Si no existe se devuelve null.

		public SearchTree()
		{
		}

        public TreeNode SearchBST(TreeNode root, int val)
        {

            if (root == null) return null;
            if (root.val == val) return root;
            //Si todavía no fue encontrado, recursivamente sigo buscando hasta
            //llegar al nodo, o llegar a null y confirmar que no existe
            if (root.val > val)
                return SearchBST(root.left, val);
            else
                return SearchBST(root.right, val);
        }
    }
}

