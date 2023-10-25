using System;
namespace LeetCode.Trees
{
	public class SumOfLeftLeaves
	{
		public SumOfLeftLeaves()
		{
		}

        //Dado un arbol binario (no necesariamente de búsqueda binaria), solamente
        //hay que sumar los valores de las hojas izquierdas, o sea, de toda hoja
        //que sea el hijo izquierdo del nodo padre.

        //Lo primero que hay que consultar es si el hijo izquierdo existe, y en
        //caso de que exista, si es una hoja.
        //Si el caso es afirmativo se retorna al mismo tiempo el valor de esa hoja
        //y un llamado a función del hijo derecho. Esto es porque de retornar
        //solamente el valor, ya no se podría chequear la hoja derecha en caso de
        //que en la primera ejecución del código el hijo izquierdo sea una hoja.
        //Para evitarlo, al mismo tiempo que ya guardo el valor, llamo a la función
        //para la hoja derecha.
        //En caso de que el hijo izquierdo no sea una hoja, se omite el condicional
        //y se llama a la función tanto por la izquierda como por la derecha.

        public int sumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;

            if (root.left != null)
            {
                if (root.left.left == null && root.left.right == null)
                    return root.left.val + sumOfLeftLeaves(root.right);
            }
            return sumOfLeftLeaves(root.left) + sumOfLeftLeaves(root.right);
        }

        // public int helper(TreeNode root, int val)
        // {
        //     if(root == null) return 0;

        //     int left = helper(root.left, root.val);
        //     if(root.val < val) return root.val;
        //     int right = helper(root.right, root.val);

        //     return (left + right);
        // }
    }
}

