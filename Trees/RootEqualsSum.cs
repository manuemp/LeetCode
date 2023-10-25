using System;
namespace LeetCode.Trees
{
	public class RootEqualsSum
	{

        //Para verificar si el valor del root de un árbol es igual a la suma
        //de sus subárboles, tengo que visitar cada uno de sus nodos, guardar
        //el valor y comparar.

		public RootEqualsSum()
		{
		}

        public bool CheckTree(TreeNode root)
        {
            Stack<int> stack = new Stack<int>();
            int res = 0;

            if (root == null) return false;

            //A medida que comparo los valores de la pila, los voy borrando
            getValues(root, stack);
            while (stack.Count > 0)
                res += stack.Pop();

            return res - root.val == root.val;
        }

        //GetValues busca los valores de todos los nodos del árbol, incluido
        //el del root, por lo que luego hay que restarlo. Cada valor es almacenado
        //en una pila
        public void getValues(TreeNode root, Stack<int> stack)
        {
            if (root == null) return;

            getValues(root.left, stack);
            getValues(root.right, stack);

            stack.Push(root.val);
        }
    }
}

//Misma idea pero en vez de usar una pila uso un entero.
//El codigo es más limpio, pero un poco menos eficiente al parecer

//public bool CheckTree(TreeNode root)
//{
//    if (root == null) return false;
//    return getValues(root) - root.val == root.val;
//}

//public int getValues(TreeNode root)
//{
//    if (root == null) return 0;

//    int left = getValues(root.left);
//    int right = getValues(root.right);

//    return left + right + root.val;
//}

